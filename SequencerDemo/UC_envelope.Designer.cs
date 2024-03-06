namespace SequencerDemo
{
    partial class UC_envelope
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trkBarAtt = new System.Windows.Forms.TrackBar();
            this.trkBarDec = new System.Windows.Forms.TrackBar();
            this.trkBarSus = new System.Windows.Forms.TrackBar();
            this.lblValueAtt = new System.Windows.Forms.Label();
            this.lblValueDec = new System.Windows.Forms.Label();
            this.lblValueSus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trkBarRel = new System.Windows.Forms.TrackBar();
            this.lblValueRel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarAtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarDec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarSus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarRel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(0, 5);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(203, 21);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Envelope";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sustain";
            // 
            // trkBarAtt
            // 
            this.trkBarAtt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trkBarAtt.LargeChange = 1;
            this.trkBarAtt.Location = new System.Drawing.Point(2, 52);
            this.trkBarAtt.Maximum = 127;
            this.trkBarAtt.Name = "trkBarAtt";
            this.trkBarAtt.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkBarAtt.Size = new System.Drawing.Size(45, 233);
            this.trkBarAtt.TabIndex = 2;
            this.trkBarAtt.TickFrequency = 2;
            this.trkBarAtt.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trkBarDec
            // 
            this.trkBarDec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trkBarDec.LargeChange = 1;
            this.trkBarDec.Location = new System.Drawing.Point(53, 52);
            this.trkBarDec.Maximum = 127;
            this.trkBarDec.Name = "trkBarDec";
            this.trkBarDec.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkBarDec.Size = new System.Drawing.Size(45, 233);
            this.trkBarDec.TabIndex = 2;
            this.trkBarDec.TickFrequency = 2;
            this.trkBarDec.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trkBarSus
            // 
            this.trkBarSus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trkBarSus.LargeChange = 1;
            this.trkBarSus.Location = new System.Drawing.Point(104, 52);
            this.trkBarSus.Maximum = 127;
            this.trkBarSus.Name = "trkBarSus";
            this.trkBarSus.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkBarSus.Size = new System.Drawing.Size(45, 233);
            this.trkBarSus.TabIndex = 2;
            this.trkBarSus.TickFrequency = 2;
            this.trkBarSus.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // lblValueAtt
            // 
            this.lblValueAtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValueAtt.AutoSize = true;
            this.lblValueAtt.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueAtt.Location = new System.Drawing.Point(10, 286);
            this.lblValueAtt.Name = "lblValueAtt";
            this.lblValueAtt.Size = new System.Drawing.Size(28, 14);
            this.lblValueAtt.TabIndex = 3;
            this.lblValueAtt.Text = "000";
            // 
            // lblValueDec
            // 
            this.lblValueDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValueDec.AutoSize = true;
            this.lblValueDec.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueDec.Location = new System.Drawing.Point(60, 286);
            this.lblValueDec.Name = "lblValueDec";
            this.lblValueDec.Size = new System.Drawing.Size(28, 14);
            this.lblValueDec.TabIndex = 3;
            this.lblValueDec.Text = "000";
            // 
            // lblValueSus
            // 
            this.lblValueSus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValueSus.AutoSize = true;
            this.lblValueSus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueSus.Location = new System.Drawing.Point(112, 286);
            this.lblValueSus.Name = "lblValueSus";
            this.lblValueSus.Size = new System.Drawing.Size(28, 14);
            this.lblValueSus.TabIndex = 3;
            this.lblValueSus.Text = "000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Release";
            // 
            // trkBarRel
            // 
            this.trkBarRel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trkBarRel.LargeChange = 1;
            this.trkBarRel.Location = new System.Drawing.Point(155, 52);
            this.trkBarRel.Maximum = 127;
            this.trkBarRel.Name = "trkBarRel";
            this.trkBarRel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkBarRel.Size = new System.Drawing.Size(45, 233);
            this.trkBarRel.TabIndex = 2;
            this.trkBarRel.TickFrequency = 2;
            this.trkBarRel.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // lblValueRel
            // 
            this.lblValueRel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValueRel.AutoSize = true;
            this.lblValueRel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueRel.Location = new System.Drawing.Point(163, 286);
            this.lblValueRel.Name = "lblValueRel";
            this.lblValueRel.Size = new System.Drawing.Size(28, 14);
            this.lblValueRel.TabIndex = 3;
            this.lblValueRel.Text = "000";
            // 
            // UC_envelope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblValueRel);
            this.Controls.Add(this.lblValueSus);
            this.Controls.Add(this.lblValueDec);
            this.Controls.Add(this.lblValueAtt);
            this.Controls.Add(this.trkBarRel);
            this.Controls.Add(this.trkBarSus);
            this.Controls.Add(this.trkBarDec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trkBarAtt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMain);
            this.Name = "UC_envelope";
            this.Size = new System.Drawing.Size(203, 314);
            ((System.ComponentModel.ISupportInitialize)(this.trkBarAtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarDec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarSus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarRel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trkBarAtt;
        private System.Windows.Forms.TrackBar trkBarDec;
        private System.Windows.Forms.TrackBar trkBarSus;
        private System.Windows.Forms.Label lblValueAtt;
        private System.Windows.Forms.Label lblValueDec;
        private System.Windows.Forms.Label lblValueSus;
        public System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trkBarRel;
        private System.Windows.Forms.Label lblValueRel;
    }
}
