
namespace FinalTask
{
    partial class frmLogin
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
            this.lblMail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.pctDoor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctDoor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblMail.Location = new System.Drawing.Point(482, 124);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(84, 20);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "כתובת מייל";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblName.Location = new System.Drawing.Point(477, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "שם משתמש:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(254, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 26);
            this.txtUserName.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(254, 121);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(155, 26);
            this.txtMail.TabIndex = 7;
            // 
            // pctDoor
            // 
            this.pctDoor.Image = global::FinalTask.Properties.Resources.Door;
            this.pctDoor.Location = new System.Drawing.Point(254, 197);
            this.pctDoor.Name = "pctDoor";
            this.pctDoor.Size = new System.Drawing.Size(174, 212);
            this.pctDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDoor.TabIndex = 11;
            this.pctDoor.TabStop = false;
            this.pctDoor.Click += new System.EventHandler(this.pctDoor_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalTask.Properties.Resources.backblu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctDoor);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtMail);
            this.Name = "frmLogin";
            this.Text = "התחבר";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctDoor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.PictureBox pctDoor;
    }
}

