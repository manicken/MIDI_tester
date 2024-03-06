using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sanford.Multimedia.Midi;
using Sanford.Multimedia.Midi.UI;

namespace SequencerDemo
{
    public partial class Form1 : Form
    {
        private bool scrolling = false;

        private bool playing = false;

        private bool closing = false;

        private OutputDevice outDevice;
        private InputDevice inputDevice;

        private int outDeviceID = 0;
        private int intDeviceID = 0;

        private OutputDeviceDialog outDialog = new OutputDeviceDialog();

        private bool debugMidiMessageInput = false;
        private bool debugMidiMessageOutput = false;

        private int oldTempo = 0;

        public Form1()
        {
            InitializeComponent();
            pianoControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            ctrlEnvelope.SetUids(102, 103, 104, 105);

            ctrlPulseWidth.SetUids(23, 24, 25);
            ctrlPhase.SetUids(26, 27, 28);
            ctrlMixer.SetUids(29, 30, 31);


            ctrlMixer.SendData += CtrlConfig_SendData;
            ctrlPhase.SendData += CtrlConfig_SendData;
            ctrlPulseWidth.SendData += CtrlConfig_SendData;
            ctrlEnvelope.SendData += CtrlConfig_SendData;

            lstBoxWaveformOscA.MouseWheel += LstBoxWaveformSel_MouseWheel;
            lstBoxWaveformOscB.MouseWheel += LstBoxWaveformSel_MouseWheel;
            lstBoxWaveformOscC.MouseWheel += LstBoxWaveformSel_MouseWheel;
            lstBoxWaveformOscA.SelectedIndex = 0;
            lstBoxWaveformOscB.SelectedIndex = 0;
            lstBoxWaveformOscC.SelectedIndex = 0;
            lstBoxWaveformOscA.SelectedIndexChanged += lstBoxWaveformOscA_SelectedIndexChanged;
            lstBoxWaveformOscB.SelectedIndexChanged += lstBoxWaveformOscB_SelectedIndexChanged;
            lstBoxWaveformOscC.SelectedIndexChanged += lstBoxWaveformOscC_SelectedIndexChanged;
        }
        private void outDevice_DataSent(int message)
        {
            if (chkDebugMidiMessageOutput.Checked)
            {
                int status = message & 0xFF;
                int data1 = (message >> 8) & 0xFF;
                int data2 = (message >> 16) & 0xFF;
                AppendRtxtLogLine($"Status: 0x{status:X2}, Data1: 0x{data1:X2}, Data2: 0x{data2:X2}");
            }
               
        }

        private void lstBoxWaveformOscA_SelectedIndexChanged(object sender, EventArgs e)
        {
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 20, lstBoxWaveformOscA.SelectedIndex));
        }

        private void lstBoxWaveformOscB_SelectedIndexChanged(object sender, EventArgs e)
        {
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 21, lstBoxWaveformOscB.SelectedIndex));
        }

        private void lstBoxWaveformOscC_SelectedIndexChanged(object sender, EventArgs e)
        {
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 22, lstBoxWaveformOscC.SelectedIndex));
        }

        private void LstBoxWaveformSel_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            ListBox lb = (ListBox)sender;
            if (e.Delta > 0)
            {
                if (lb.SelectedIndex != 0)
                    lb.SelectedIndex--;
            }
            else if (e.Delta < 0)
            {
                if (lb.SelectedIndex != (lb.Items.Count - 1))
                    lb.SelectedIndex++;
            }
        }

        private void CtrlConfig_SendData(int data1, int data2)
        {
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, data1, data2));
        }
        

        protected override void OnLoad(EventArgs e)
        {

            if (OutputDevice.DeviceCount == 0)
            {
                MessageBox.Show("No MIDI output devices available.", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                Close();
            }
            else
            {
                try
                {
                    outDevice = new OutputDevice(outDeviceID);
                    outDevice.DataSent += outDevice_DataSent;

                    sequence1.LoadProgressChanged += HandleLoadProgressChanged;
                    sequence1.LoadCompleted += HandleLoadCompleted;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    Close();
                }
            }
            if (InputDevice.DeviceCount == 0)
            {
                AppendRtxtLogLine("Information: No MIDI input devices available.");
            }
            else
            {
                try
                {
                    CreateNewInputDevice();

                    sequence1.LoadProgressChanged += HandleLoadProgressChanged;
                    sequence1.LoadCompleted += HandleLoadCompleted;
                }
                catch (Exception ex)
                {
                    AppendRtxtLogLine("Error:\r\n" + ex.Message);
                }
            }

            base.OnLoad(e);
        }

        private void CreateNewInputDevice()
        {
            if (inputDevice != null)
            {
                inputDevice.StopRecording();
                inputDevice.Close();
                inputDevice.Dispose();
            }
            inputDevice = new InputDevice(intDeviceID);
            PrintInputDeviceCap(intDeviceID);
            inputDevice.ChannelMessageReceived += InputDevice_ChannelMessageReceived;
            inputDevice.SysExMessageReceived += InputDevice_SysExMessageReceived;
            inputDevice.StartRecording();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            pianoControl1.PressPianoKey(e.KeyCode);

            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            pianoControl1.ReleasePianoKey(e.KeyCode);

            base.OnKeyUp(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            closing = true;

            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {

            sequence1.Dispose();

            if (outDevice != null)
            {
                outDevice.Close();
                outDevice.Dispose();
            }
            if (inputDevice != null)
            {
                inputDevice.StopRecording();
                inputDevice.Close();
                inputDevice.Dispose();
            }
            outDialog.Dispose();

            base.OnClosed(e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openMidiFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openMidiFileDialog.FileName;

                try
                {
                    sequencer1.Stop();
                    playing = false;
                    sequence1.LoadAsync(fileName);
                    this.Cursor = Cursors.WaitCursor;
                    startButton.Enabled = false;
                    continueButton.Enabled = false;
                    stopButton.Enabled = false;
                    openToolStripMenuItem.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void outputDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (outDialog.ShowDialog() == DialogResult.OK)
            {
                if (outDevice != null)
                {
                    outDevice.Close();
                    outDevice.Dispose();

                }
                outDeviceID = outDialog.OutputDeviceID;
                outDevice = new OutputDevice(outDeviceID);
                PrintOutputDeviceCap(outDeviceID);
            }
        }

        private void InputDevice_ChannelMessageReceived(object sender, ChannelMessageEventArgs e)
        {
            ChannelMessage cm = e.Message;

            if (debugMidiMessageInput)
            {
                rtxtLog.Invoke((MethodInvoker)delegate
                {

                    rtxtLog.AppendText(cm.Command.ToString() + " " + cm.Data1.ToString() + " " + cm.Data2.ToString() + "\r\n");
                });
            }
            pianoControl1.Send(cm);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog dlg = new AboutDialog();

            dlg.ShowDialog();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            try
            {
                playing = false;
                sequencer1.Stop();
                timer1.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                playing = true;
                sequencer1.Start();

                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                playing = true;
                sequencer1.Continue();
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void positionHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
                sequencer1.Position = e.NewValue;

                scrolling = false;
            }
            else
            {
                scrolling = true;
            }
        }

        private void HandleLoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void HandleLoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            startButton.Enabled = true;
            continueButton.Enabled = true;
            stopButton.Enabled = true;
            openToolStripMenuItem.Enabled = true;
            toolStripProgressBar1.Value = 0;

            if (e.Error == null)
            {
                positionHScrollBar.Minimum = 1;
                positionHScrollBar.Value = 1;
                positionHScrollBar.Maximum = sequence1.GetLength();
                AppendRtxtLogLine("tempo:" + sequencer1.clock.Tempo);
                positionHScrollBar.Maximum = sequencer1.clock.Tempo * 2;
                
            }
            else
            {
                MessageBox.Show(e.Error.Message);
            }
        }

        private void HandleChannelMessagePlayed(object sender, ChannelMessageEventArgs e)
        {
            if (closing)
            {
                return;
            }
            ChannelMessage cm = e.Message;

            if ((cm.Command == ChannelCommand.NoteOn) && (cm.Data2 == 0))
                cm = new ChannelMessage(ChannelCommand.NoteOff, cm.MidiChannel, cm.Data1, cm.Data2);
            try
            {
                outDevice.Send(cm);
            }
            catch
            {
                outDevice = new OutputDevice(outDeviceID);
                outDevice.Send(cm);
            }
            pianoControl1.Send(e.Message);
            if (oldTempo != sequencer1.clock.Tempo)
            {
                oldTempo = sequencer1.clock.Tempo;
                positionHScrollBar.Invoke((MethodInvoker)delegate
                {

                    positionHScrollBar.Value = sequencer1.clock.Tempo;
                });
                AppendRtxtLogLine("tempo:" + sequencer1.clock.Tempo);
            }
            if (debugMidiMessageOutput)
            {
                rtxtLog.Invoke((MethodInvoker)delegate
                {

                    rtxtLog.AppendText(cm.Command.ToString() + " " + cm.Data1.ToString() + " " + cm.Data2.ToString() + "\r\n");
                });
            }
        }

        private void HandleChased(object sender, ChasedEventArgs e)
        {
            foreach (ChannelMessage message in e.Messages)
            {
                outDevice.Send(message);
            }
        }

        private void HandleSysExMessagePlayed(object sender, SysExMessageEventArgs e)
        {
            //     outDevice.Send(e.Message); Sometimes causes an exception to be thrown because the output device is overloaded.
        }

        private void HandleStopped(object sender, StoppedEventArgs e)
        {
            foreach (ChannelMessage message in e.Messages)
            {
                outDevice.Send(message);
                pianoControl1.Send(message);
            }
        }

        private void HandlePlayingCompleted(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pianoControl1_PianoKeyDown(object sender, PianoKeyEventArgs e)
        {
            #region Guard

            if (playing)
            {
                return;
            }

            #endregion

            outDevice.Send(new ChannelMessage(ChannelCommand.NoteOn, 0, e.NoteID, 127));
        }

        private void pianoControl1_PianoKeyUp(object sender, PianoKeyEventArgs e)
        {
            #region Guard

            if (playing)
            {
                return;
            }

            #endregion

            outDevice.Send(new ChannelMessage(ChannelCommand.NoteOff, 0, e.NoteID, 0));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!scrolling)
            {
                positionHScrollBar.Value = sequencer1.Position;
            }
        }

        private void btnSetEnvelope_Click(object sender, EventArgs e)
        {
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 102, 0)); // attack
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 103, 0)); // decay
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 104, 127)); // sustain level
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 105, 0)); // release
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void AppendRtxtLogLine(string text)
        {
            rtxtLog.Invoke((MethodInvoker)delegate
            {
                rtxtLog.AppendText(text + "\r\n");
            });
        }

        private void PrintInputDeviceCap(int id)
        {
            MidiInCaps mic = InputDevice.GetDeviceCapabilities(id);
            AppendRtxtLogLine("------------------------------------");
            AppendRtxtLogLine("Name: " + mic.name);
            AppendRtxtLogLine("mId: " + mic.mid.ToString());
            AppendRtxtLogLine("driverVersion: " + mic.driverVersion.ToString());
            AppendRtxtLogLine("pid: " + mic.pid.ToString());
            AppendRtxtLogLine("support: " + mic.support.ToString());
        }

        private void PrintOutputDeviceCap(int id)
        {
            MidiOutCaps moc = OutputDevice.GetDeviceCapabilities(id);
            AppendRtxtLogLine("------------------------------------");
            AppendRtxtLogLine("Name: " + moc.name);
            AppendRtxtLogLine("mId: " + moc.mid.ToString());
            AppendRtxtLogLine("driverVersion: " + moc.driverVersion.ToString());
            AppendRtxtLogLine("pid: " + moc.pid.ToString());
            AppendRtxtLogLine("support: " + moc.support.ToString());
            AppendRtxtLogLine("notes: " + moc.notes.ToString());
            AppendRtxtLogLine("technology:" + moc.technology.ToString());
            AppendRtxtLogLine("voices: " + moc.voices.ToString());
            AppendRtxtLogLine("channelMask: " + moc.channelMask.ToString());
        }

        private void inputDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputDeviceDialog inputDeviceDialog = new InputDeviceDialog();
            if (inputDeviceDialog.ShowDialog() == DialogResult.OK)
            {
                intDeviceID = inputDeviceDialog.InputDeviceID;
                CreateNewInputDevice();

            }
        }

        private string GetAsString(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] >= 0x20 && bytes[i] <= 0x7D) // normal characters
                    sb.Append((char)bytes[i]);
                else
                {
                    sb.Append('[');
                    sb.Append(bytes[i].ToString("X"));
                    sb.Append(']');
                }
            }
            return sb.ToString();
        }

        private void InputDevice_SysExMessageReceived(object sender, SysExMessageEventArgs e)
        {
            SysExMessage sem = e.Message;
            byte[] bytes = sem.GetBytes();
            rtxtLog.Invoke((MethodInvoker)delegate
            {

                rtxtLog.AppendText(sem.Length.ToString() + " " + GetAsString(bytes) + "\r\n");
            });
        }

        private void InputDevice_SysCommonMessageReceived(object sender, SysCommonMessageEventArgs e)
        {
            SysCommonMessage scm = e.Message;
            rtxtLog.Invoke((MethodInvoker)delegate
            {

                rtxtLog.AppendText(scm.Data1.ToString() + " " + scm.Data2.ToString() + "\r\n");
            });
        }

        private void InputDevice_Error(object sender, Sanford.Multimedia.ErrorEventArgs e)
        {
            rtxtLog.Invoke((MethodInvoker)delegate
            {

                rtxtLog.AppendText(e.Error.ToString() + "\r\n");
            });
        }

        private void InputDevice_InvalidShortMessageReceived(object sender, InvalidShortMessageEventArgs e)
        {
            rtxtLog.Invoke((MethodInvoker)delegate
            {

                rtxtLog.AppendText(e.Message.ToString() + "\r\n");
            });
        }

        private void chkDebugMidiMessageInput_CheckedChanged(object sender, EventArgs e)
        {
            debugMidiMessageInput = chkDebugMidiMessageInput.Checked;
        }

        private void chkDebugMidiMessageOutput_CheckedChanged(object sender, EventArgs e)
        {
            debugMidiMessageOutput = chkDebugMidiMessageOutput.Checked;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            sequencer1.clock.Tempo = positionHScrollBar.Value;
        }

        private void uC_Trackbars1_SendData(int uid, int value)
        {

        }
    }
}