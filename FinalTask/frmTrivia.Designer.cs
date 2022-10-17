
namespace FinalTask
{
    partial class frmTrivia
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
            this.components = new System.ComponentModel.Container();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.bttSend = new System.Windows.Forms.Button();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.timGameTIme = new System.Windows.Forms.Timer(this.components);
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtCorrect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(267, 54);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(267, 27);
            this.txtTime.TabIndex = 10;
            // 
            // bttSend
            // 
            this.bttSend.Location = new System.Drawing.Point(343, 343);
            this.bttSend.Name = "bttSend";
            this.bttSend.Size = new System.Drawing.Size(120, 86);
            this.bttSend.TabIndex = 9;
            this.bttSend.Text = "שחק";
            this.bttSend.UseVisualStyleBackColor = true;
            this.bttSend.Click += new System.EventHandler(this.bttSend_Click);
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(267, 12);
            this.txtPoints.Multiline = true;
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.Size = new System.Drawing.Size(267, 27);
            this.txtPoints.TabIndex = 8;
            // 
            // timGameTIme
            // 
            this.timGameTIme.Interval = 1000;
            this.timGameTIme.Tick += new System.EventHandler(this.timGameTIme_Tick);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(267, 154);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(267, 27);
            this.txtAmount.TabIndex = 11;
            // 
            // txtCorrect
            // 
            this.txtCorrect.Location = new System.Drawing.Point(267, 108);
            this.txtCorrect.Multiline = true;
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.ReadOnly = true;
            this.txtCorrect.Size = new System.Drawing.Size(267, 27);
            this.txtCorrect.TabIndex = 12;
            // 
            // frmTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalTask.Properties.Resources.shapes42;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCorrect);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.bttSend);
            this.Controls.Add(this.txtPoints);
            this.Name = "frmTrivia";
            this.Text = "טריוויה";
            this.Load += new System.EventHandler(this.frmTrivia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button bttSend;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Timer timGameTIme;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtCorrect;
    }
}