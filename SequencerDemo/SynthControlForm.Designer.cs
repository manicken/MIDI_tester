
namespace SequencerDemo
{
    partial class SynthControlForm
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
            this.ctrlMixer = new SequencerDemo.UC_Trackbars();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBoxWaveformOscC = new System.Windows.Forms.ListBox();
            this.lstBoxWaveformOscB = new System.Windows.Forms.ListBox();
            this.lstBoxWaveformOscA = new System.Windows.Forms.ListBox();
            this.btnSetEnvelope = new System.Windows.Forms.Button();
            this.ctrlPulseWidth = new SequencerDemo.UC_Trackbars();
            this.ctrlPhase = new SequencerDemo.UC_Trackbars();
            this.ctrlEnvelope = new SequencerDemo.UC_Trackbars();
            this.SuspendLayout();
            // 
            // ctrlMixer
            // 
            this.ctrlMixer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlMixer.Location = new System.Drawing.Point(6, 32);
            this.ctrlMixer.Name = "ctrlMixer";
            this.ctrlMixer.Size = new System.Drawing.Size(151, 282);
            this.ctrlMixer.TabIndex = 25;
            this.ctrlMixer.TitleLabel = "Mixer";
            this.ctrlMixer.Trackbar_Count = 3;
            this.ctrlMixer.TrackBar_MaxValues = new int[] {
        127,
        127,
        127};
            this.ctrlMixer.TrackBar_MinValues = new int[] {
        0,
        0,
        0};
            this.ctrlMixer.Trackbar_Padding = 0;
            this.ctrlMixer.Trackbar_Titles = new string[] {
        "OSC-A",
        "OSC-B",
        "OSC-C"};
            this.ctrlMixer.TrackBar_Uids = new int[] {
        29,
        30,
        31};
            this.ctrlMixer.TrackBar_valueLblMult = new float[] {
        1F,
        1F,
        1F};
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(913, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "OSC-C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(817, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "OSC-B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "OSC-A";
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
            this.lstBoxWaveformOscC.Location = new System.Drawing.Point(888, 49);
            this.lstBoxWaveformOscC.Name = "lstBoxWaveformOscC";
            this.lstBoxWaveformOscC.Size = new System.Drawing.Size(92, 121);
            this.lstBoxWaveformOscC.TabIndex = 19;
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
            this.lstBoxWaveformOscB.Location = new System.Drawing.Point(790, 48);
            this.lstBoxWaveformOscB.Name = "lstBoxWaveformOscB";
            this.lstBoxWaveformOscB.Size = new System.Drawing.Size(92, 121);
            this.lstBoxWaveformOscB.TabIndex = 20;
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
            this.lstBoxWaveformOscA.Location = new System.Drawing.Point(688, 48);
            this.lstBoxWaveformOscA.Name = "lstBoxWaveformOscA";
            this.lstBoxWaveformOscA.Size = new System.Drawing.Size(96, 121);
            this.lstBoxWaveformOscA.TabIndex = 21;
            // 
            // btnSetEnvelope
            // 
            this.btnSetEnvelope.Location = new System.Drawing.Point(6, 1);
            this.btnSetEnvelope.Name = "btnSetEnvelope";
            this.btnSetEnvelope.Size = new System.Drawing.Size(75, 23);
            this.btnSetEnvelope.TabIndex = 26;
            this.btnSetEnvelope.Text = "setEnvelope";
            this.btnSetEnvelope.UseVisualStyleBackColor = true;
            this.btnSetEnvelope.Click += new System.EventHandler(this.btnSetEnvelope_Click);
            // 
            // ctrlPulseWidth
            // 
            this.ctrlPulseWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlPulseWidth.Location = new System.Drawing.Point(163, 32);
            this.ctrlPulseWidth.Name = "ctrlPulseWidth";
            this.ctrlPulseWidth.Size = new System.Drawing.Size(152, 282);
            this.ctrlPulseWidth.TabIndex = 31;
            this.ctrlPulseWidth.TitleLabel = "Pulse width";
            this.ctrlPulseWidth.Trackbar_Count = 3;
            this.ctrlPulseWidth.TrackBar_MaxValues = new int[] {
        127,
        127,
        127};
            this.ctrlPulseWidth.TrackBar_MinValues = new int[] {
        0,
        0,
        0};
            this.ctrlPulseWidth.Trackbar_Padding = 0;
            this.ctrlPulseWidth.Trackbar_Titles = new string[] {
        "OSC-A",
        "OSC-B",
        "OSC-C"};
            this.ctrlPulseWidth.TrackBar_Uids = new int[] {
        23,
        24,
        25};
            this.ctrlPulseWidth.TrackBar_valueLblMult = new float[] {
        1F,
        1F,
        1F};
            // 
            // ctrlPhase
            // 
            this.ctrlPhase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlPhase.Location = new System.Drawing.Point(321, 32);
            this.ctrlPhase.Name = "ctrlPhase";
            this.ctrlPhase.Size = new System.Drawing.Size(155, 282);
            this.ctrlPhase.TabIndex = 32;
            this.ctrlPhase.TitleLabel = "Phase";
            this.ctrlPhase.Trackbar_Count = 3;
            this.ctrlPhase.TrackBar_MaxValues = new int[] {
        127,
        127,
        127};
            this.ctrlPhase.TrackBar_MinValues = new int[] {
        0,
        0,
        0};
            this.ctrlPhase.Trackbar_Padding = 0;
            this.ctrlPhase.Trackbar_Titles = new string[] {
        "OSC-A",
        "OSC-B",
        "OSC-C"};
            this.ctrlPhase.TrackBar_Uids = new int[] {
        26,
        27,
        28};
            this.ctrlPhase.TrackBar_valueLblMult = new float[] {
        1F,
        1F,
        1F};
            // 
            // ctrlEnvelope
            // 
            this.ctrlEnvelope.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlEnvelope.Location = new System.Drawing.Point(482, 32);
            this.ctrlEnvelope.Name = "ctrlEnvelope";
            this.ctrlEnvelope.Size = new System.Drawing.Size(200, 282);
            this.ctrlEnvelope.TabIndex = 33;
            this.ctrlEnvelope.TitleLabel = "Envelope";
            this.ctrlEnvelope.Trackbar_Count = 4;
            this.ctrlEnvelope.TrackBar_MaxValues = new int[] {
        127,
        127,
        127,
        127};
            this.ctrlEnvelope.TrackBar_MinValues = new int[] {
        0,
        0,
        0,
        0};
            this.ctrlEnvelope.Trackbar_Padding = 0;
            this.ctrlEnvelope.Trackbar_Titles = new string[] {
        "Attack",
        "Decay",
        "Sustain",
        "Release"};
            this.ctrlEnvelope.TrackBar_Uids = new int[] {
        102,
        103,
        104,
        105};
            this.ctrlEnvelope.TrackBar_valueLblMult = new float[] {
        1F,
        1F,
        1F,
        1F};
            // 
            // SynthControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 322);
            this.Controls.Add(this.ctrlEnvelope);
            this.Controls.Add(this.ctrlPhase);
            this.Controls.Add(this.ctrlPulseWidth);
            this.Controls.Add(this.btnSetEnvelope);
            this.Controls.Add(this.ctrlMixer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxWaveformOscC);
            this.Controls.Add(this.lstBoxWaveformOscB);
            this.Controls.Add(this.lstBoxWaveformOscA);
            this.Name = "SynthControlForm";
            this.Text = "SynthControlForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SynthControlForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_Trackbars ctrlMixer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxWaveformOscC;
        private System.Windows.Forms.ListBox lstBoxWaveformOscB;
        private System.Windows.Forms.ListBox lstBoxWaveformOscA;
        private System.Windows.Forms.Button btnSetEnvelope;
        private UC_Trackbars ctrlPulseWidth;
        private UC_Trackbars ctrlPhase;
        private UC_Trackbars ctrlEnvelope;
    }
}