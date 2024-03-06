using Sanford.Multimedia.Midi;

namespace SequencerDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.positionHScrollBar = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mIDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMidiFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.pianoControl1 = new Sanford.Multimedia.Midi.UI.PianoControl();
            this.sequence1 = new Sanford.Multimedia.Midi.Sequence();
            this.sequencer1 = new Sanford.Multimedia.Midi.Sequencer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.btnSetEnvelope = new System.Windows.Forms.Button();
            this.lstBoxWaveformOscA = new System.Windows.Forms.ListBox();
            this.lstBoxWaveformOscB = new System.Windows.Forms.ListBox();
            this.lstBoxWaveformOscC = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDebugMidiMessageInput = new System.Windows.Forms.CheckBox();
            this.chkDebugMidiMessageOutput = new System.Windows.Forms.CheckBox();
            this.uC_Trackbars1 = new SequencerDemo.UC_Trackbars();
            this.ctrlEnvelope = new SequencerDemo.UC_envelope();
            this.ctrlPhase = new SequencerDemo.UC_3osc_sliders();
            this.ctrlPulseWidth = new SequencerDemo.UC_3osc_sliders();
            this.ctrlMixer = new SequencerDemo.UC_3osc_sliders();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(86, 79);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(185, 79);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(286, 79);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // positionHScrollBar
            // 
            this.positionHScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionHScrollBar.Location = new System.Drawing.Point(12, 46);
            this.positionHScrollBar.Name = "positionHScrollBar";
            this.positionHScrollBar.Size = new System.Drawing.Size(1214, 18);
            this.positionHScrollBar.TabIndex = 3;
            this.positionHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.positionHScrollBar_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mIDIToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mIDIToolStripMenuItem
            // 
            this.mIDIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputDeviceToolStripMenuItem,
            this.inputDeviceToolStripMenuItem});
            this.mIDIToolStripMenuItem.Name = "mIDIToolStripMenuItem";
            this.mIDIToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.mIDIToolStripMenuItem.Text = "&MIDI";
            // 
            // outputDeviceToolStripMenuItem
            // 
            this.outputDeviceToolStripMenuItem.Name = "outputDeviceToolStripMenuItem";
            this.outputDeviceToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.outputDeviceToolStripMenuItem.Text = "Output Device...";
            this.outputDeviceToolStripMenuItem.Click += new System.EventHandler(this.outputDeviceToolStripMenuItem_Click);
            // 
            // inputDeviceToolStripMenuItem
            // 
            this.inputDeviceToolStripMenuItem.Name = "inputDeviceToolStripMenuItem";
            this.inputDeviceToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.inputDeviceToolStripMenuItem.Text = "Input Device";
            this.inputDeviceToolStripMenuItem.Click += new System.EventHandler(this.inputDeviceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openMidiFileDialog
            // 
            this.openMidiFileDialog.DefaultExt = "mid";
            this.openMidiFileDialog.Filter = "MIDI files|*.mid|All files|*.*";
            this.openMidiFileDialog.Title = "Open MIDI file";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1238, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // pianoControl1
            // 
            this.pianoControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pianoControl1.HighNoteID = 109;
            this.pianoControl1.Location = new System.Drawing.Point(12, 120);
            this.pianoControl1.LowNoteID = 21;
            this.pianoControl1.Name = "pianoControl1";
            this.pianoControl1.NoteOnColor = System.Drawing.Color.SkyBlue;
            this.pianoControl1.Size = new System.Drawing.Size(1214, 48);
            this.pianoControl1.TabIndex = 5;
            this.pianoControl1.Text = "pianoControl1";
            this.pianoControl1.PianoKeyDown += new System.EventHandler<Sanford.Multimedia.Midi.UI.PianoKeyEventArgs>(this.pianoControl1_PianoKeyDown);
            this.pianoControl1.PianoKeyUp += new System.EventHandler<Sanford.Multimedia.Midi.UI.PianoKeyEventArgs>(this.pianoControl1_PianoKeyUp);
            // 
            // sequence1
            // 
            this.sequence1.Format = 1;
            // 
            // sequencer1
            // 
            this.sequencer1.Position = 0;
            this.sequencer1.Sequence = this.sequence1;
            this.sequencer1.PlayingCompleted += new System.EventHandler(this.HandlePlayingCompleted);
            this.sequencer1.ChannelMessagePlayed += new System.EventHandler<Sanford.Multimedia.Midi.ChannelMessageEventArgs>(this.HandleChannelMessagePlayed);
            this.sequencer1.SysExMessagePlayed += new System.EventHandler<Sanford.Multimedia.Midi.SysExMessageEventArgs>(this.HandleSysExMessagePlayed);
            this.sequencer1.Chased += new System.EventHandler<Sanford.Multimedia.Midi.ChasedEventArgs>(this.HandleChased);
            this.sequencer1.Stopped += new System.EventHandler<Sanford.Multimedia.Midi.StoppedEventArgs>(this.HandleStopped);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtxtLog
            // 
            this.rtxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtxtLog.Location = new System.Drawing.Point(16, 178);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.Size = new System.Drawing.Size(214, 283);
            this.rtxtLog.TabIndex = 7;
            this.rtxtLog.Text = "";
            // 
            // btnSetEnvelope
            // 
            this.btnSetEnvelope.Location = new System.Drawing.Point(448, 77);
            this.btnSetEnvelope.Name = "btnSetEnvelope";
            this.btnSetEnvelope.Size = new System.Drawing.Size(75, 23);
            this.btnSetEnvelope.TabIndex = 8;
            this.btnSetEnvelope.Text = "setEnvelope";
            this.btnSetEnvelope.UseVisualStyleBackColor = true;
            this.btnSetEnvelope.Click += new System.EventHandler(this.btnSetEnvelope_Click);
            // 
            // lstBoxWaveformOscA
            // 
            this.lstBoxWaveformOscA.FormattingEnabled = true;
            this.lstBoxWaveformOscA.Items.AddRange(new object[] {
            "SINE",
            "SAWTOOTH",
            "SQUARE",
            "TRIANGLE",
            "ARBITRARY",
            "PULSE",
            "SAW REVERSE",
            "SAMPLE HOLD",
            "VAR. TRIANGLE"});
            this.lstBoxWaveformOscA.Location = new System.Drawing.Point(913, 188);
            this.lstBoxWaveformOscA.Name = "lstBoxWaveformOscA";
            this.lstBoxWaveformOscA.Size = new System.Drawing.Size(96, 121);
            this.lstBoxWaveformOscA.TabIndex = 12;
            this.lstBoxWaveformOscA.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lstBoxWaveformOscB
            // 
            this.lstBoxWaveformOscB.FormattingEnabled = true;
            this.lstBoxWaveformOscB.Items.AddRange(new object[] {
            "SINE",
            "SAWTOOTH",
            "SQUARE",
            "TRIANGLE",
            "ARBITRARY",
            "PULSE",
            "SAW REVERSE",
            "SAMPLE HOLD",
            "VAR. TRIANGLE"});
            this.lstBoxWaveformOscB.Location = new System.Drawing.Point(1015, 189);
            this.lstBoxWaveformOscB.Name = "lstBoxWaveformOscB";
            this.lstBoxWaveformOscB.Size = new System.Drawing.Size(92, 121);
            this.lstBoxWaveformOscB.TabIndex = 12;
            this.lstBoxWaveformOscB.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lstBoxWaveformOscC
            // 
            this.lstBoxWaveformOscC.FormattingEnabled = true;
            this.lstBoxWaveformOscC.Items.AddRange(new object[] {
            "SINE",
            "SAWTOOTH",
            "SQUARE",
            "TRIANGLE",
            "ARBITRARY",
            "PULSE",
            "SAW REVERSE",
            "SAMPLE HOLD",
            "VAR. TRIANGLE"});
            this.lstBoxWaveformOscC.Location = new System.Drawing.Point(1113, 190);
            this.lstBoxWaveformOscC.Name = "lstBoxWaveformOscC";
            this.lstBoxWaveformOscC.Size = new System.Drawing.Size(92, 121);
            this.lstBoxWaveformOscC.TabIndex = 12;
            this.lstBoxWaveformOscC.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1138, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "OSC-C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1042, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "OSC-B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(942, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "OSC-A";
            // 
            // chkDebugMidiMessageInput
            // 
            this.chkDebugMidiMessageInput.AutoSize = true;
            this.chkDebugMidiMessageInput.Location = new System.Drawing.Point(573, 87);
            this.chkDebugMidiMessageInput.Name = "chkDebugMidiMessageInput";
            this.chkDebugMidiMessageInput.Size = new System.Drawing.Size(142, 17);
            this.chkDebugMidiMessageInput.TabIndex = 16;
            this.chkDebugMidiMessageInput.Text = "debugMidiMessageInput";
            this.chkDebugMidiMessageInput.UseVisualStyleBackColor = true;
            this.chkDebugMidiMessageInput.CheckedChanged += new System.EventHandler(this.chkDebugMidiMessageInput_CheckedChanged);
            // 
            // chkDebugMidiMessageOutput
            // 
            this.chkDebugMidiMessageOutput.AutoSize = true;
            this.chkDebugMidiMessageOutput.Location = new System.Drawing.Point(739, 82);
            this.chkDebugMidiMessageOutput.Name = "chkDebugMidiMessageOutput";
            this.chkDebugMidiMessageOutput.Size = new System.Drawing.Size(150, 17);
            this.chkDebugMidiMessageOutput.TabIndex = 17;
            this.chkDebugMidiMessageOutput.Text = "debugMidiMessageOutput";
            this.chkDebugMidiMessageOutput.UseVisualStyleBackColor = true;
            this.chkDebugMidiMessageOutput.CheckedChanged += new System.EventHandler(this.chkDebugMidiMessageOutput_CheckedChanged);
            // 
            // uC_Trackbars1
            // 
            this.uC_Trackbars1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_Trackbars1.Location = new System.Drawing.Point(1015, 316);
            this.uC_Trackbars1.Name = "uC_Trackbars1";
            this.uC_Trackbars1.Size = new System.Drawing.Size(162, 151);
            this.uC_Trackbars1.TabIndex = 18;
            this.uC_Trackbars1.TitleLabel = "Mixer";
            this.uC_Trackbars1.Trackbar_Count = 3;
            this.uC_Trackbars1.TrackBar_MaxValues = new int[] {
        100,
        100,
        100};
            this.uC_Trackbars1.TrackBar_MinValues = new int[] {
        0,
        0,
        0};
            this.uC_Trackbars1.Trackbar_Padding = 0;
            this.uC_Trackbars1.Trackbar_Titles = new string[] {
        "OSC-A",
        "OSC-B",
        "OSC-C"};
            this.uC_Trackbars1.TrackBar_Uids = new int[] {
        -1,
        -1,
        -1};
            this.uC_Trackbars1.TrackBar_valueLblMult = new float[] {
        1F,
        1F,
        1F};
            this.uC_Trackbars1.SendData += new SequencerDemo.UC_Trackbars.SendHandler(this.uC_Trackbars1_SendData);
            // 
            // ctrlEnvelope
            // 
            this.ctrlEnvelope.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlEnvelope.Location = new System.Drawing.Point(704, 174);
            this.ctrlEnvelope.Name = "ctrlEnvelope";
            this.ctrlEnvelope.Size = new System.Drawing.Size(203, 283);
            this.ctrlEnvelope.TabIndex = 10;
            this.ctrlEnvelope.TitleLabel = "Envelope";
            // 
            // ctrlPhase
            // 
            this.ctrlPhase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlPhase.Location = new System.Drawing.Point(548, 174);
            this.ctrlPhase.Name = "ctrlPhase";
            this.ctrlPhase.Size = new System.Drawing.Size(150, 283);
            this.ctrlPhase.TabIndex = 9;
            this.ctrlPhase.TitleLabel = "Phase";
            // 
            // ctrlPulseWidth
            // 
            this.ctrlPulseWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlPulseWidth.Location = new System.Drawing.Point(392, 174);
            this.ctrlPulseWidth.Name = "ctrlPulseWidth";
            this.ctrlPulseWidth.Size = new System.Drawing.Size(150, 283);
            this.ctrlPulseWidth.TabIndex = 9;
            this.ctrlPulseWidth.TitleLabel = "Pulse width";
            // 
            // ctrlMixer
            // 
            this.ctrlMixer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlMixer.Location = new System.Drawing.Point(236, 174);
            this.ctrlMixer.Name = "ctrlMixer";
            this.ctrlMixer.Size = new System.Drawing.Size(150, 283);
            this.ctrlMixer.TabIndex = 9;
            this.ctrlMixer.TitleLabel = "Mixer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 495);
            this.Controls.Add(this.uC_Trackbars1);
            this.Controls.Add(this.chkDebugMidiMessageOutput);
            this.Controls.Add(this.chkDebugMidiMessageInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxWaveformOscC);
            this.Controls.Add(this.lstBoxWaveformOscB);
            this.Controls.Add(this.lstBoxWaveformOscA);
            this.Controls.Add(this.ctrlEnvelope);
            this.Controls.Add(this.ctrlPhase);
            this.Controls.Add(this.ctrlPulseWidth);
            this.Controls.Add(this.ctrlMixer);
            this.Controls.Add(this.btnSetEnvelope);
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pianoControl1);
            this.Controls.Add(this.positionHScrollBar);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sequencer Demo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.HScrollBar positionHScrollBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openMidiFileDialog;
        private Sanford.Multimedia.Midi.UI.PianoControl pianoControl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem mIDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputDeviceToolStripMenuItem;
        private Sequence sequence1;
        private Sequencer sequencer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.Button btnSetEnvelope;
        private UC_3osc_sliders ctrlMixer;
        private UC_3osc_sliders ctrlPulseWidth;
        private UC_3osc_sliders ctrlPhase;
        private UC_envelope ctrlEnvelope;
        private System.Windows.Forms.ListBox lstBoxWaveformOscA;
        private System.Windows.Forms.ListBox lstBoxWaveformOscB;
        private System.Windows.Forms.ListBox lstBoxWaveformOscC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem inputDeviceToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkDebugMidiMessageInput;
        private System.Windows.Forms.CheckBox chkDebugMidiMessageOutput;
        private UC_Trackbars uC_Trackbars1;
    }
}

