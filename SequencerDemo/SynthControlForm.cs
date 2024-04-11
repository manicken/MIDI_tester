using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SequencerDemo
{
    public partial class SynthControlForm : Form
    {
        public delegate void SendHandler(int data1, int data2);
        public event SendHandler SendData;
        private void TrySend(int data1, int data2)
        {
            if (SendData == null) return;
            SendData(data1, data2);
        }

        public SynthControlForm()
        {
            InitializeComponent();

            lstBoxWaveformOscA.MouseWheel += LstBoxWaveformSel_MouseWheel;
            lstBoxWaveformOscB.MouseWheel += LstBoxWaveformSel_MouseWheel;
            lstBoxWaveformOscC.MouseWheel += LstBoxWaveformSel_MouseWheel;
            lstBoxWaveformOscA.SelectedIndex = 0;
            lstBoxWaveformOscB.SelectedIndex = 0;
            lstBoxWaveformOscC.SelectedIndex = 0;
            lstBoxWaveformOscA.SelectedIndexChanged += lstBoxWaveformOscA_SelectedIndexChanged;
            lstBoxWaveformOscB.SelectedIndexChanged += lstBoxWaveformOscB_SelectedIndexChanged;
            lstBoxWaveformOscC.SelectedIndexChanged += lstBoxWaveformOscC_SelectedIndexChanged;

            ctrlMixer.SendData += TrySend;
            ctrlPhase.SendData += TrySend;
            ctrlPulseWidth.SendData += TrySend;
            ctrlEnvelope.SendData += TrySend;

            ctrlEnvelope.Hide_UidDesignerLbls();
            ctrlMixer.Hide_UidDesignerLbls();
            ctrlPulseWidth.Hide_UidDesignerLbls();
            ctrlPhase.Hide_UidDesignerLbls();
        }

        private void lstBoxWaveformOscA_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrySend(20, lstBoxWaveformOscA.SelectedIndex);
            //outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 20, lstBoxWaveformOscA.SelectedIndex));
        }

        private void lstBoxWaveformOscB_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrySend(21, lstBoxWaveformOscB.SelectedIndex);
            //outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 21, lstBoxWaveformOscB.SelectedIndex));
        }

        private void lstBoxWaveformOscC_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrySend(22, lstBoxWaveformOscC.SelectedIndex);
            //outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 22, lstBoxWaveformOscC.SelectedIndex));
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

        private void btnSetEnvelope_Click(object sender, EventArgs e)
        {
            TrySend(102, 0);
            TrySend(103, 0);
            TrySend(104, 127);
            TrySend(105, 0);
            /*
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 102, 0)); // attack
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 103, 0)); // decay
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 104, 127)); // sustain level
            outDevice.Send(new ChannelMessage(ChannelCommand.Controller, 0x00, 105, 0)); // release
            */
        }

        private void SynthControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) { e.Cancel = true; this.Visible = false; }
        }
    }
}
