using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SequencerDemo
{
    public partial class UC_envelope : UserControl
    {
        public delegate void SendHandler(int data1, int data2);
        public event SendHandler SendData;

        public void Send(int data1, int data2)
        {
            if (SendData == null)
                return;
            SendData(data1, data2);
        }

        public void SetUids(int A, int B, int C, int D)
        {
            uid_attack = A;
            uid_decay = B;
            uid_sustain = C;
            uid_release = D;
        }

        public int uid_attack = 0;
        public int uid_decay = 0;
        public int uid_sustain = 0;
        public int uid_release = 0;

        public bool valuesUpdating = false;

        [Browsable(true)]
        public string TitleLabel
        {
            get
            {
                return this.lblMain.Text;
            }
            set
            {
                lblMain.Text = value;
            }
        }

        public UC_envelope()
        {
            InitializeComponent();

            trkBarAtt.ValueChanged += trkBarAtt_ValueChanged;
            trkBarDec.ValueChanged += trkBarDec_ValueChanged;
            trkBarSus.ValueChanged += trkBarSus_ValueChanged;
            trkBarRel.ValueChanged += trkBarRel_ValueChanged;

            trkBarAtt.MouseWheel += trkBars_MouseWheel;
            trkBarDec.MouseWheel += trkBars_MouseWheel;
            trkBarSus.MouseWheel += trkBars_MouseWheel;
            trkBarRel.MouseWheel += trkBars_MouseWheel;
        }

        private void trkBars_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
            TrackBar tb = (TrackBar)sender;
            if (e.Delta > 0)
            {
                IncreaseValue(tb, tb.SmallChange);
            }
            else if (e.Delta < 0)
            {
                DecreaseValue(tb, tb.SmallChange);
            }
        }

        private void trkBarAtt_ValueChanged(object sender, EventArgs e)
        {
            if (valuesUpdating) return;
            lblValueAtt.Text = trkBarAtt.Value.ToString();
            Send(uid_attack, trkBarAtt.Value);
        }
        private void trkBarDec_ValueChanged(object sender, EventArgs e)
        {
            if (valuesUpdating) return;
            lblValueDec.Text = trkBarDec.Value.ToString();
            Send(uid_decay, trkBarDec.Value);
        }
        private void trkBarSus_ValueChanged(object sender, EventArgs e)
        {
            if (valuesUpdating) return;
            lblValueSus.Text = trkBarSus.Value.ToString();
            Send(uid_sustain, trkBarSus.Value);
        }
        private void trkBarRel_ValueChanged(object sender, EventArgs e)
        {
            if (valuesUpdating) return;
            lblValueRel.Text = trkBarRel.Value.ToString();
            Send(uid_release, trkBarRel.Value);
        }

        public void IncreaseValue(TrackBar thisTrkBar, int value)
        {
            value = thisTrkBar.Value + value;
            if (value > thisTrkBar.Maximum)
                thisTrkBar.Value = thisTrkBar.Maximum;
            else
                thisTrkBar.Value = value;
        }
        public void DecreaseValue(TrackBar thisTrkBar, int value)
        {
            value = thisTrkBar.Value - value;
            if (value < thisTrkBar.Minimum)
                thisTrkBar.Value = thisTrkBar.Minimum;
            else
                thisTrkBar.Value = value;
        }
    }
}
