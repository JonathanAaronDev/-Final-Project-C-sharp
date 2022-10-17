
namespace FinalTask
{
    partial class frmAddType1
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
            this.pctAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(495, 194);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(53, 20);
            this.lblAnswer.TabIndex = 14;
            this.lblAnswer.Text = "תשובה";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(500, 84);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(48, 20);
            this.lblQuestion.TabIndex = 13;
            this.lblQuestion.Text = "שאלה";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(259, 194);
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
            // pctAdd
            // 
            this.pctAdd.Image = global::FinalTask.Properties.Resources.Plus;
            this.pctAdd.Location = new System.Drawing.Point(242, 261);
            this.pctAdd.Name = "pctAdd";
            this.pctAdd.Size = new System.Drawing.Size(184, 119);
            this.pctAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAdd.TabIndex = 10;
            this.pctAdd.TabStop = false;
            this.pctAdd.Click += new System.EventHandler(this.pctAdd_Click);
            // 
            // frmAddType1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = global::FinalTask.Properties.Resources.teacher_teaching_geometry_math;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.pctAdd);
            this.Name = "frmAddType1";
            this.Text = "הוספת שאלה";
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
    }
}