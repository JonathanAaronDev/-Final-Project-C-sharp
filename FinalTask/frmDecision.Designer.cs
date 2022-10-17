
namespace FinalTask
{
    partial class frmDecision
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
            this.pctLearning = new System.Windows.Forms.PictureBox();
            this.pctTrivia = new System.Windows.Forms.PictureBox();
            this.pctUpdate = new System.Windows.Forms.PictureBox();
            this.bttBegin = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbAmount = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLearning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrivia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLearning
            // 
            this.pctLearning.Image = global::FinalTask.Properties.Resources.Learn;
            this.pctLearning.Location = new System.Drawing.Point(496, 162);
            this.pctLearning.Name = "pctLearning";
            this.pctLearning.Size = new System.Drawing.Size(143, 61);
            this.pctLearning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLearning.TabIndex = 0;
            this.pctLearning.TabStop = false;
            this.pctLearning.Click += new System.EventHandler(this.pctLearning_Click);
            // 
            // pctTrivia
            // 
            this.pctTrivia.Image = global::FinalTask.Properties.Resources.TriviaButton;
            this.pctTrivia.Location = new System.Drawing.Point(292, 162);
            this.pctTrivia.Name = "pctTrivia";
            this.pctTrivia.Size = new System.Drawing.Size(122, 61);
            this.pctTrivia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTrivia.TabIndex = 1;
            this.pctTrivia.TabStop = false;
            this.pctTrivia.Click += new System.EventHandler(this.pctTrivia_Click);
            // 
            // pctUpdate
            // 
            this.pctUpdate.Image = global::FinalTask.Properties.Resources.Update;
            this.pctUpdate.Location = new System.Drawing.Point(106, 162);
            this.pctUpdate.Name = "pctUpdate";
            this.pctUpdate.Size = new System.Drawing.Size(111, 61);
            this.pctUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUpdate.TabIndex = 2;
            this.pctUpdate.TabStop = false;
            this.pctUpdate.Click += new System.EventHandler(this.pctUpdate_Click);
            // 
            // bttBegin
            // 
            this.bttBegin.Location = new System.Drawing.Point(282, 334);
            this.bttBegin.Name = "bttBegin";
            this.bttBegin.Size = new System.Drawing.Size(120, 50);
            this.bttBegin.TabIndex = 10;
            this.bttBegin.Text = "התחל";
            this.bttBegin.UseVisualStyleBackColor = true;
            this.bttBegin.Visible = false;
            this.bttBegin.Click += new System.EventHandler(this.bttBegin_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblAmount.Location = new System.Drawing.Point(450, 283);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(91, 20);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "כמות שאלות";
            this.lblAmount.Visible = false;
            // 
            // cmbAmount
            // 
            this.cmbAmount.FormattingEnabled = true;
            this.cmbAmount.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10"});
            this.cmbAmount.Location = new System.Drawing.Point(281, 280);
            this.cmbAmount.Name = "cmbAmount";
            this.cmbAmount.Size = new System.Drawing.Size(121, 28);
            this.cmbAmount.TabIndex = 8;
            this.cmbAmount.Visible = false;
            // 
            // frmDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalTask.Properties.Resources.Untitled_design_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttBegin);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbAmount);
            this.Controls.Add(this.pctUpdate);
            this.Controls.Add(this.pctTrivia);
            this.Controls.Add(this.pctLearning);
            this.Name = "frmDecision";
            this.Text = "ברוך הבא";
            this.Load += new System.EventHandler(this.frmDecision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLearning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrivia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLearning;
        private System.Windows.Forms.PictureBox pctTrivia;
        private System.Windows.Forms.PictureBox pctUpdate;
        private System.Windows.Forms.Button bttBegin;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbAmount;
    }
}