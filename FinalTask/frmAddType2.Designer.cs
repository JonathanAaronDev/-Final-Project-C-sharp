
namespace FinalTask
{
    partial class frmAddType2
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
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.ofdAdd = new System.Windows.Forms.OpenFileDialog();
            this.pctAddPic = new System.Windows.Forms.PictureBox();
            this.pctAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblAnswer.Location = new System.Drawing.Point(505, 174);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(53, 20);
            this.lblAnswer.TabIndex = 14;
            this.lblAnswer.Text = "תשובה";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblQuestion.Location = new System.Drawing.Point(510, 84);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(48, 20);
            this.lblQuestion.TabIndex = 13;
            this.lblQuestion.Text = "שאלה";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(253, 174);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(167, 26);
            this.txtAnswer.TabIndex = 12;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(259, 70);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(161, 69);
            this.txtQuestion.TabIndex = 11;
            // 
            // ofdAdd
            // 
            this.ofdAdd.FileName = "openFileDialog1";
            // 
            // pctAddPic
            // 
            this.pctAddPic.Image = global::FinalTask.Properties.Resources.Addpic;
            this.pctAddPic.Location = new System.Drawing.Point(277, 226);
            this.pctAddPic.Name = "pctAddPic";
            this.pctAddPic.Size = new System.Drawing.Size(126, 66);
            this.pctAddPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAddPic.TabIndex = 15;
            this.pctAddPic.TabStop = false;
            this.pctAddPic.Click += new System.EventHandler(this.pctAddPic_Click);
            // 
            // pctAdd
            // 
            this.pctAdd.Enabled = false;
            this.pctAdd.Image = global::FinalTask.Properties.Resources.Plus;
            this.pctAdd.Location = new System.Drawing.Point(236, 319);
            this.pctAdd.Name = "pctAdd";
            this.pctAdd.Size = new System.Drawing.Size(184, 119);
            this.pctAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAdd.TabIndex = 10;
            this.pctAdd.TabStop = false;
            this.pctAdd.Click += new System.EventHandler(this.pctAdd_Click);
            // 
            // frmAddType2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.BackgroundImage = global::FinalTask.Properties.Resources.teacher_teaching_geometry_math;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctAddPic);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.pctAdd);
            this.Name = "frmAddType2";
            this.Text = "הוסף שאלה";
            this.Load += new System.EventHandler(this.frmAddType2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAddPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.PictureBox pctAdd;
        private System.Windows.Forms.OpenFileDialog ofdAdd;
        private System.Windows.Forms.PictureBox pctAddPic;
    }
}