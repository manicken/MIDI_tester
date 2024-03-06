using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SequencerDemo
{
    public partial class UC_3osc_sliders : UserControl
    {
        public delegate void SendHandler(int data1, int data2);
        public event SendHandler SendData;

        public void Send(int data1, int data2)
        {
            if (SendData == null)
                return;
            SendData(data1, data2);
        }

        public int uid_oscA = 0;
        public int uid_oscB = 0;
        public int uid_oscC = 0;

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

        public UC_3osc_sliders()
        {
            InitializeComponent();

            trkBarA.ValueChanged += trkBarA_ValueChanged;
            trkBarB.ValueChanged += trkBarB_ValueChanged;
            trkBarC.ValueChanged += trkBarC_ValueChanged;

            trkBarA.MouseWheel += trkBars_MouseWheel;
            trkBarB.MouseWheel += trkBars_MouseWheel;
            trkBarC.MouseWheel += trkBars_MouseWheel;
        }

        public void SetUids(int A, int B, int C)
        {
            uid_oscA = A;
            uid_oscB = B;
            uid_oscC = C;
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

        private void trkBarA_ValueChanged(object sender, EventArgs e)
        {
            if (valuesUpdating) return;
            lblValueA.Text = trkBarA.Value.ToString();
            Send(uid_oscA, trkBarA.Value);
        }
        private void trkBarB_ValueChanged(object sender, EventArgs e)
        {
            if (valuesUpdating) return;
            lblValueB.Text = trkBarB.Value.ToString();
            Send(uid_oscB, trkBarB.Value);
        }
        private void trkBarC_ValueChanged(object sender, EventArgs e)
        {
            if (valuesUpdating) return;
            lblValueC.Text = trkBarC.Value.ToString();
            Send(uid_oscC, trkBarC.Value);
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
