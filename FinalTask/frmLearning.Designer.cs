
namespace FinalTask
{
    partial class frmLearning
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
            this.lblCounter = new System.Windows.Forms.Label();
            this.pctStop = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.pctShape = new System.Windows.Forms.PictureBox();
            this.pctContinue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctContinue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.BackColor = System.Drawing.Color.MistyRose;
            this.lblCounter.Location = new System.Drawing.Point(343, 75);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(100, 20);
            this.lblCounter.TabIndex = 9;
            this.lblCounter.Text = "ברוכים הבאים";
            // 
            // pctStop
            // 
            this.pctStop.Enabled = false;
            this.pctStop.Image = global::FinalTask.Properties.Resources.Stop;
            this.pctStop.Location = new System.Drawing.Point(149, 255);
            this.pctStop.Name = "pctStop";
            this.pctStop.Size = new System.Drawing.Size(160, 120);
            this.pctStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctStop.TabIndex = 8;
            this.pctStop.TabStop = false;
            this.pctStop.Click += new System.EventHandler(this.pctStop_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(436, 119);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(257, 114);
            this.txtInfo.TabIndex = 7;
            // 
            // pctShape
            // 
            this.pctShape.Location = new System.Drawing.Point(118, 103);
            this.pctShape.Name = "pctShape";
            this.pctShape.Size = new System.Drawing.Size(171, 103);
            this.pctShape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctShape.TabIndex = 6;
            this.pctShape.TabStop = false;
            // 
            // pctContinue
            // 
            this.pctContinue.Image = global::FinalTask.Properties.Resources.Continue;
            this.pctContinue.Location = new System.Drawing.Point(391, 255);
            this.pctContinue.Name = "pctContinue";
            this.pctContinue.Size = new System.Drawing.Size(147, 120);
            this.pctContinue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctContinue.TabIndex = 5;
            this.pctContinue.TabStop = false;
            this.pctContinue.Click += new System.EventHandler(this.pctContinue_Click);
            // 
            // frmLearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalTask.Properties.Resources.math_teacher_teaching1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.pctStop);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.pctShape);
            this.Controls.Add(this.pctContinue);
            this.Name = "frmLearning";
            this.Text = "למידה מהנה";
            this.Load += new System.EventHandler(this.frmLearning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctContinue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.PictureBox pctStop;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.PictureBox pctShape;
        private System.Windows.Forms.PictureBox pctContinue;
    }
}