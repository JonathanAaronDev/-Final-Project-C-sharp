
namespace FinalTask
{
    partial class frmAddType3
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
            this.lblExmpale = new System.Windows.Forms.Label();
            this.txtExmpale = new System.Windows.Forms.TextBox();
            this.lblInsert = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.ofdAdd = new System.Windows.Forms.OpenFileDialog();
            this.pctAddFile1 = new System.Windows.Forms.PictureBox();
            this.pctAddFile2 = new System.Windows.Forms.PictureBox();
            this.pctConfirm = new System.Windows.Forms.PictureBox();
            this.pctAddtofile = new System.Windows.Forms.PictureBox();
            this.pctAddFile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddFile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddFile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddtofile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddFile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExmpale
            // 
            this.lblExmpale.AutoSize = true;
            this.lblExmpale.Location = new System.Drawing.Point(556, 62);
            this.lblExmpale.Name = "lblExmpale";
            this.lblExmpale.Size = new System.Drawing.Size(54, 20);
            this.lblExmpale.TabIndex = 26;
            this.lblExmpale.Text = "דוגמא:";
            // 
            // txtExmpale
            // 
            this.txtExmpale.Location = new System.Drawing.Point(256, 62);
            this.txtExmpale.Name = "txtExmpale";
            this.txtExmpale.Size = new System.Drawing.Size(294, 26);
            this.txtExmpale.TabIndex = 25;
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Location = new System.Drawing.Point(535, 123);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(79, 20);
            this.lblInsert.TabIndex = 19;
            this.lblInsert.Text = "הכנס מידע";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(265, 120);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(264, 26);
            this.txtInfo.TabIndex = 18;
            // 
            // ofdAdd
            // 
            this.ofdAdd.FileName = "openFileDialog1";
            // 
            // pctAddFile1
            // 
            this.pctAddFile1.Image = global::FinalTask.Properties.Resources.Addpic;
            this.pctAddFile1.Location = new System.Drawing.Point(315, 208);
            this.pctAddFile1.Name = "pctAddFile1";
            this.pctAddFile1.Size = new System.Drawing.Size(164, 56);
            this.pctAddFile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAddFile1.TabIndex = 24;
            this.pctAddFile1.TabStop = false;
            this.pctAddFile1.Visible = false;
            this.pctAddFile1.Click += new System.EventHandler(this.pctAddFile1_Click);
            // 
            // pctAddFile2
            // 
            this.pctAddFile2.Image = global::FinalTask.Properties.Resources.Addpic;
            this.pctAddFile2.Location = new System.Drawing.Point(102, 208);
            this.pctAddFile2.Name = "pctAddFile2";
            this.pctAddFile2.Size = new System.Drawing.Size(164, 56);
            this.pctAddFile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAddFile2.TabIndex = 23;
            this.pctAddFile2.TabStop = false;
            this.pctAddFile2.Visible = false;
            this.pctAddFile2.Click += new System.EventHandler(this.pctAddFile2_Click);
            // 
            // pctConfirm
            // 
            this.pctConfirm.Image = global::FinalTask.Properties.Resources.Confirm;
            this.pctConfirm.Location = new System.Drawing.Point(123, 145);
            this.pctConfirm.Name = "pctConfirm";
            this.pctConfirm.Size = new System.Drawing.Size(123, 51);
            this.pctConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctConfirm.TabIndex = 22;
            this.pctConfirm.TabStop = false;
            this.pctConfirm.Click += new System.EventHandler(this.pctConfirm_Click);
            // 
            // pctAddtofile
            // 
            this.pctAddtofile.Image = global::FinalTask.Properties.Resources.AddFile;
            this.pctAddtofile.Location = new System.Drawing.Point(347, 314);
            this.pctAddtofile.Name = "pctAddtofile";
            this.pctAddtofile.Size = new System.Drawing.Size(182, 75);
            this.pctAddtofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAddtofile.TabIndex = 21;
            this.pctAddtofile.TabStop = false;
            this.pctAddtofile.Click += new System.EventHandler(this.pctAddtofile_Click);
            // 
            // pctAddFile
            // 
            this.pctAddFile.Image = global::FinalTask.Properties.Resources.Addpic;
            this.pctAddFile.Location = new System.Drawing.Point(518, 208);
            this.pctAddFile.Name = "pctAddFile";
            this.pctAddFile.Size = new System.Drawing.Size(164, 56);
            this.pctAddFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAddFile.TabIndex = 20;
            this.pctAddFile.TabStop = false;
            this.pctAddFile.Visible = false;
            this.pctAddFile.Click += new System.EventHandler(this.pctAddFile_Click);
            // 
            // frmAddType3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::FinalTask.Properties.Resources.teacher_teaching_geometry_math;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExmpale);
            this.Controls.Add(this.txtExmpale);
            this.Controls.Add(this.pctAddFile1);
            this.Controls.Add(this.pctAddFile2);
            this.Controls.Add(this.pctConfirm);
            this.Controls.Add(this.pctAddtofile);
            this.Controls.Add(this.pctAddFile);
            this.Controls.Add(this.lblInsert);
            this.Controls.Add(this.txtInfo);
            this.Name = "frmAddType3";
            this.Text = "הוסף שאלה";
            this.Load += new System.EventHandler(this.frmAddType3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAddFile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddFile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddtofile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExmpale;
        private System.Windows.Forms.TextBox txtExmpale;
        private System.Windows.Forms.PictureBox pctAddFile1;
        private System.Windows.Forms.PictureBox pctAddFile2;
        private System.Windows.Forms.PictureBox pctConfirm;
        private System.Windows.Forms.PictureBox pctAddtofile;
        private System.Windows.Forms.PictureBox pctAddFile;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.OpenFileDialog ofdAdd;
    }
}