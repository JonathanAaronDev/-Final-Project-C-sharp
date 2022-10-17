
namespace FinalTask
{
    partial class frmQ2Q3
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
            this.rdbOpt3 = new System.Windows.Forms.RadioButton();
            this.rdbOpt2 = new System.Windows.Forms.RadioButton();
            this.bttSend = new System.Windows.Forms.Button();
            this.pctOption3 = new System.Windows.Forms.PictureBox();
            this.pctOption2 = new System.Windows.Forms.PictureBox();
            this.pctOption1 = new System.Windows.Forms.PictureBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.rdbOpt1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctOption3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOption2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOption1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbOpt3
            // 
            this.rdbOpt3.AutoSize = true;
            this.rdbOpt3.Location = new System.Drawing.Point(98, 167);
            this.rdbOpt3.Name = "rdbOpt3";
            this.rdbOpt3.Size = new System.Drawing.Size(43, 24);
            this.rdbOpt3.TabIndex = 14;
            this.rdbOpt3.TabStop = true;
            this.rdbOpt3.Text = "3";
            this.rdbOpt3.UseVisualStyleBackColor = true;
            // 
            // rdbOpt2
            // 
            this.rdbOpt2.AutoSize = true;
            this.rdbOpt2.Location = new System.Drawing.Point(374, 167);
            this.rdbOpt2.Name = "rdbOpt2";
            this.rdbOpt2.Size = new System.Drawing.Size(43, 24);
            this.rdbOpt2.TabIndex = 13;
            this.rdbOpt2.TabStop = true;
            this.rdbOpt2.Text = "2";
            this.rdbOpt2.UseVisualStyleBackColor = true;
            // 
            // bttSend
            // 
            this.bttSend.Location = new System.Drawing.Point(308, 373);
            this.bttSend.Name = "bttSend";
            this.bttSend.Size = new System.Drawing.Size(121, 65);
            this.bttSend.TabIndex = 12;
            this.bttSend.Text = "שלח";
            this.bttSend.UseVisualStyleBackColor = true;
            this.bttSend.Click += new System.EventHandler(this.bttSend_Click);
            // 
            // pctOption3
            // 
            this.pctOption3.Location = new System.Drawing.Point(59, 74);
            this.pctOption3.Name = "pctOption3";
            this.pctOption3.Size = new System.Drawing.Size(127, 75);
            this.pctOption3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOption3.TabIndex = 11;
            this.pctOption3.TabStop = false;
            // 
            // pctOption2
            // 
            this.pctOption2.Location = new System.Drawing.Point(330, 74);
            this.pctOption2.Name = "pctOption2";
            this.pctOption2.Size = new System.Drawing.Size(127, 75);
            this.pctOption2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOption2.TabIndex = 10;
            this.pctOption2.TabStop = false;
            // 
            // pctOption1
            // 
            this.pctOption1.Location = new System.Drawing.Point(588, 74);
            this.pctOption1.Name = "pctOption1";
            this.pctOption1.Size = new System.Drawing.Size(114, 75);
            this.pctOption1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOption1.TabIndex = 9;
            this.pctOption1.TabStop = false;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(213, 239);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(325, 112);
            this.txtQuestion.TabIndex = 8;
            // 
            // rdbOpt1
            // 
            this.rdbOpt1.AutoSize = true;
            this.rdbOpt1.Location = new System.Drawing.Point(629, 167);
            this.rdbOpt1.Name = "rdbOpt1";
            this.rdbOpt1.Size = new System.Drawing.Size(43, 24);
            this.rdbOpt1.TabIndex = 15;
            this.rdbOpt1.TabStop = true;
            this.rdbOpt1.Text = "1";
            this.rdbOpt1.UseVisualStyleBackColor = true;
            // 
            // frmQ2Q3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalTask.Properties.Resources.shape1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbOpt1);
            this.Controls.Add(this.rdbOpt3);
            this.Controls.Add(this.rdbOpt2);
            this.Controls.Add(this.bttSend);
            this.Controls.Add(this.pctOption3);
            this.Controls.Add(this.pctOption2);
            this.Controls.Add(this.pctOption1);
            this.Controls.Add(this.txtQuestion);
            this.Name = "frmQ2Q3";
            this.Text = "ענה על השאלה";
            this.Load += new System.EventHandler(this.frmQ2Q3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctOption3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOption2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOption1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbOpt3;
        private System.Windows.Forms.RadioButton rdbOpt2;
        private System.Windows.Forms.Button bttSend;
        private System.Windows.Forms.PictureBox pctOption3;
        private System.Windows.Forms.PictureBox pctOption2;
        private System.Windows.Forms.PictureBox pctOption1;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.RadioButton rdbOpt1;
    }
}