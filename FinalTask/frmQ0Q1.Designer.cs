
namespace FinalTask
{
    partial class frmQ0Q1
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
            this.bttSend = new System.Windows.Forms.Button();
            this.rdbOpt3 = new System.Windows.Forms.RadioButton();
            this.rdbOpt2 = new System.Windows.Forms.RadioButton();
            this.rdbOpt1 = new System.Windows.Forms.RadioButton();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttSend
            // 
            this.bttSend.Location = new System.Drawing.Point(348, 365);
            this.bttSend.Name = "bttSend";
            this.bttSend.Size = new System.Drawing.Size(105, 52);
            this.bttSend.TabIndex = 9;
            this.bttSend.Text = "שלח";
            this.bttSend.UseVisualStyleBackColor = true;
            this.bttSend.Click += new System.EventHandler(this.bttSend_Click);
            // 
            // rdbOpt3
            // 
            this.rdbOpt3.AutoSize = true;
            this.rdbOpt3.Location = new System.Drawing.Point(217, 298);
            this.rdbOpt3.Name = "rdbOpt3";
            this.rdbOpt3.Size = new System.Drawing.Size(126, 24);
            this.rdbOpt3.TabIndex = 8;
            this.rdbOpt3.TabStop = true;
            this.rdbOpt3.Text = "radioButton3";
            this.rdbOpt3.UseVisualStyleBackColor = true;
            // 
            // rdbOpt2
            // 
            this.rdbOpt2.AutoSize = true;
            this.rdbOpt2.Location = new System.Drawing.Point(217, 255);
            this.rdbOpt2.Name = "rdbOpt2";
            this.rdbOpt2.Size = new System.Drawing.Size(126, 24);
            this.rdbOpt2.TabIndex = 7;
            this.rdbOpt2.TabStop = true;
            this.rdbOpt2.Text = "radioButton2";
            this.rdbOpt2.UseVisualStyleBackColor = true;
            // 
            // rdbOpt1
            // 
            this.rdbOpt1.AutoSize = true;
            this.rdbOpt1.Location = new System.Drawing.Point(217, 212);
            this.rdbOpt1.Name = "rdbOpt1";
            this.rdbOpt1.Size = new System.Drawing.Size(126, 24);
            this.rdbOpt1.TabIndex = 6;
            this.rdbOpt1.TabStop = true;
            this.rdbOpt1.Text = "radioButton1";
            this.rdbOpt1.UseVisualStyleBackColor = true;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(265, 34);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(271, 142);
            this.txtQuestion.TabIndex = 5;
            // 
            // frmQ0Q1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalTask.Properties.Resources.shape1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttSend);
            this.Controls.Add(this.rdbOpt3);
            this.Controls.Add(this.rdbOpt2);
            this.Controls.Add(this.rdbOpt1);
            this.Controls.Add(this.txtQuestion);
            this.Name = "frmQ0Q1";
            this.Text = "ענה על השאלה";
            this.Load += new System.EventHandler(this.frmQ0Q1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttSend;
        private System.Windows.Forms.RadioButton rdbOpt3;
        private System.Windows.Forms.RadioButton rdbOpt2;
        private System.Windows.Forms.RadioButton rdbOpt1;
        private System.Windows.Forms.TextBox txtQuestion;
    }
}