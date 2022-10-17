
namespace FinalTask
{
    partial class frmAddData
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
            this.pctAddFile = new System.Windows.Forms.PictureBox();
            this.lblInsert = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblExample = new System.Windows.Forms.Label();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.pctInfoWithoutPicture = new System.Windows.Forms.PictureBox();
            this.pctInfoWithPicture = new System.Windows.Forms.PictureBox();
            this.ofdAdd = new System.Windows.Forms.OpenFileDialog();
            this.pctConfirm = new System.Windows.Forms.PictureBox();
            this.pctAddtofile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInfoWithoutPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInfoWithPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddtofile)).BeginInit();
            this.SuspendLayout();
            // 
            // pctAddFile
            // 
            this.pctAddFile.Image = global::FinalTask.Properties.Resources.Addpic;
            this.pctAddFile.Location = new System.Drawing.Point(303, 234);
            this.pctAddFile.Name = "pctAddFile";
            this.pctAddFile.Size = new System.Drawing.Size(164, 56);
            this.pctAddFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAddFile.TabIndex = 16;
            this.pctAddFile.TabStop = false;
            this.pctAddFile.Visible = false;
            this.pctAddFile.Click += new System.EventHandler(this.pctAddFile_Click);
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Location = new System.Drawing.Point(563, 202);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(79, 20);
            this.lblInsert.TabIndex = 15;
            this.lblInsert.Text = "הכנס מידע";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(249, 202);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(264, 26);
            this.txtInfo.TabIndex = 14;
            this.txtInfo.Visible = false;
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Location = new System.Drawing.Point(478, 65);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(271, 20);
            this.lblExample.TabIndex = 13;
            this.lblExample.Text = "דוגמא לאיך צריך להיראות פריט המידע ";
            this.lblExample.Visible = false;
            // 
            // txtExample
            // 
            this.txtExample.Location = new System.Drawing.Point(196, 65);
            this.txtExample.Name = "txtExample";
            this.txtExample.ReadOnly = true;
            this.txtExample.Size = new System.Drawing.Size(271, 26);
            this.txtExample.TabIndex = 12;
            this.txtExample.Visible = false;
            // 
            // pctInfoWithoutPicture
            // 
            this.pctInfoWithoutPicture.Image = global::FinalTask.Properties.Resources.InfoWIthOut1;
            this.pctInfoWithoutPicture.Location = new System.Drawing.Point(30, 101);
            this.pctInfoWithoutPicture.Name = "pctInfoWithoutPicture";
            this.pctInfoWithoutPicture.Size = new System.Drawing.Size(269, 83);
            this.pctInfoWithoutPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctInfoWithoutPicture.TabIndex = 11;
            this.pctInfoWithoutPicture.TabStop = false;
            this.pctInfoWithoutPicture.Click += new System.EventHandler(this.pctInfoWithoutPicture_Click);
            // 
            // pctInfoWithPicture
            // 
            this.pctInfoWithPicture.Image = global::FinalTask.Properties.Resources.InfoWIth;
            this.pctInfoWithPicture.Location = new System.Drawing.Point(461, 101);
            this.pctInfoWithPicture.Name = "pctInfoWithPicture";
            this.pctInfoWithPicture.Size = new System.Drawing.Size(269, 83);
            this.pctInfoWithPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctInfoWithPicture.TabIndex = 10;
            this.pctInfoWithPicture.TabStop = false;
            this.pctInfoWithPicture.Click += new System.EventHandler(this.pctInfoWithPicture_Click);
            // 
            // ofdAdd
            // 
            this.ofdAdd.FileName = "openFileDialog1";
            // 
            // pctConfirm
            // 
            this.pctConfirm.Image = global::FinalTask.Properties.Resources.Confirm;
            this.pctConfirm.Location = new System.Drawing.Point(99, 202);
            this.pctConfirm.Name = "pctConfirm";
            this.pctConfirm.Size = new System.Drawing.Size(123, 51);
            this.pctConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctConfirm.TabIndex = 18;
            this.pctConfirm.TabStop = false;
            this.pctConfirm.Click += new System.EventHandler(this.pctConfirm_Click);
            // 
            // pctAddtofile
            // 
            this.pctAddtofile.Image = global::FinalTask.Properties.Resources.AddFile;
            this.pctAddtofile.Location = new System.Drawing.Point(285, 312);
            this.pctAddtofile.Name = "pctAddtofile";
            this.pctAddtofile.Size = new System.Drawing.Size(182, 75);
            this.pctAddtofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAddtofile.TabIndex = 17;
            this.pctAddtofile.TabStop = false;
            this.pctAddtofile.Click += new System.EventHandler(this.pctAddtofile_Click);
            // 
            // frmAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalTask.Properties.Resources._1doodlemaths;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctAddFile);
            this.Controls.Add(this.lblInsert);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.txtExample);
            this.Controls.Add(this.pctInfoWithoutPicture);
            this.Controls.Add(this.pctInfoWithPicture);
            this.Controls.Add(this.pctConfirm);
            this.Controls.Add(this.pctAddtofile);
            this.Name = "frmAddData";
            this.Text = "הוסף פריט מידע";
            this.Load += new System.EventHandler(this.frmAddData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAddFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInfoWithoutPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInfoWithPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddtofile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctAddFile;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.PictureBox pctInfoWithoutPicture;
        private System.Windows.Forms.PictureBox pctInfoWithPicture;
        private System.Windows.Forms.OpenFileDialog ofdAdd;
        private System.Windows.Forms.PictureBox pctConfirm;
        private System.Windows.Forms.PictureBox pctAddtofile;
    }
}