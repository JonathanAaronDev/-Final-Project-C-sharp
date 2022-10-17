
namespace FinalTask
{
    partial class frmUpdate
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
            this.pctAddInfo = new System.Windows.Forms.PictureBox();
            this.pctAddQuestion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // pctAddInfo
            // 
            this.pctAddInfo.Image = global::FinalTask.Properties.Resources.Think;
            this.pctAddInfo.Location = new System.Drawing.Point(-1, 3);
            this.pctAddInfo.Name = "pctAddInfo";
            this.pctAddInfo.Size = new System.Drawing.Size(407, 445);
            this.pctAddInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAddInfo.TabIndex = 0;
            this.pctAddInfo.TabStop = false;
            this.pctAddInfo.Click += new System.EventHandler(this.pctAddInfo_Click);
            // 
            // pctAddQuestion
            // 
            this.pctAddQuestion.Image = global::FinalTask.Properties.Resources.sphinx;
            this.pctAddQuestion.Location = new System.Drawing.Point(401, 3);
            this.pctAddQuestion.Name = "pctAddQuestion";
            this.pctAddQuestion.Size = new System.Drawing.Size(399, 445);
            this.pctAddQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAddQuestion.TabIndex = 2;
            this.pctAddQuestion.TabStop = false;
            this.pctAddQuestion.Click += new System.EventHandler(this.pctAddQuestion_Click);
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctAddQuestion);
            this.Controls.Add(this.pctAddInfo);
            this.Name = "frmUpdate";
            this.Text = "עדכון בסיס נתונים";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAddInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctAddInfo;
        private System.Windows.Forms.PictureBox pctAddQuestion;
    }
}