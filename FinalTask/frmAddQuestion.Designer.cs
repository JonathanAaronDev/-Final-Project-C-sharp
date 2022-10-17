
namespace FinalTask
{
    partial class frmAddQuestion
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
            this.lblFour = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.pctTwo = new System.Windows.Forms.PictureBox();
            this.pctZero = new System.Windows.Forms.PictureBox();
            this.pctThree = new System.Windows.Forms.PictureBox();
            this.pctOne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFour
            // 
            this.lblFour.AutoSize = true;
            this.lblFour.BackColor = System.Drawing.Color.MistyRose;
            this.lblFour.Location = new System.Drawing.Point(34, 113);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(170, 20);
            this.lblFour.TabIndex = 15;
            this.lblFour.Text = "בחירה מרובה עם תמונות";
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.BackColor = System.Drawing.Color.MistyRose;
            this.lblThree.Location = new System.Drawing.Point(222, 113);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(141, 20);
            this.lblThree.TabIndex = 14;
            this.lblThree.Text = "אמת או שקר תמונות";
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.BackColor = System.Drawing.Color.MistyRose;
            this.lblTwo.Location = new System.Drawing.Point(436, 113);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(97, 20);
            this.lblTwo.TabIndex = 13;
            this.lblTwo.Text = "בחירה מרובה";
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.BackColor = System.Drawing.Color.MistyRose;
            this.lblOne.Location = new System.Drawing.Point(657, 113);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(91, 20);
            this.lblOne.TabIndex = 12;
            this.lblOne.Text = "אמת או שקר";
            // 
            // pctTwo
            // 
            this.pctTwo.Image = global::FinalTask.Properties.Resources.Two;
            this.pctTwo.Location = new System.Drawing.Point(219, 151);
            this.pctTwo.Name = "pctTwo";
            this.pctTwo.Size = new System.Drawing.Size(144, 186);
            this.pctTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTwo.TabIndex = 11;
            this.pctTwo.TabStop = false;
            this.pctTwo.Click += new System.EventHandler(this.pctTwo_Click);
            // 
            // pctZero
            // 
            this.pctZero.Image = global::FinalTask.Properties.Resources.Zero1;
            this.pctZero.Location = new System.Drawing.Point(623, 151);
            this.pctZero.Name = "pctZero";
            this.pctZero.Size = new System.Drawing.Size(144, 186);
            this.pctZero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctZero.TabIndex = 10;
            this.pctZero.TabStop = false;
            this.pctZero.Click += new System.EventHandler(this.pctZero_Click);
            // 
            // pctThree
            // 
            this.pctThree.Image = global::FinalTask.Properties.Resources.Three;
            this.pctThree.Location = new System.Drawing.Point(38, 151);
            this.pctThree.Name = "pctThree";
            this.pctThree.Size = new System.Drawing.Size(149, 174);
            this.pctThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctThree.TabIndex = 9;
            this.pctThree.TabStop = false;
            this.pctThree.Click += new System.EventHandler(this.pctThree_Click);
            // 
            // pctOne
            // 
            this.pctOne.Image = global::FinalTask.Properties.Resources.One;
            this.pctOne.Location = new System.Drawing.Point(406, 151);
            this.pctOne.Name = "pctOne";
            this.pctOne.Size = new System.Drawing.Size(159, 186);
            this.pctOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOne.TabIndex = 8;
            this.pctOne.TabStop = false;
            this.pctOne.Click += new System.EventHandler(this.pctOne_Click);
            // 
            // frmAddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalTask.Properties.Resources._1doodlemaths1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFour);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.pctTwo);
            this.Controls.Add(this.pctZero);
            this.Controls.Add(this.pctThree);
            this.Controls.Add(this.pctOne);
            this.Name = "frmAddQuestion";
            this.Text = "בחר איזה סוג שאלה ברצונך להוסיף";
            this.Load += new System.EventHandler(this.frmAddQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.PictureBox pctTwo;
        private System.Windows.Forms.PictureBox pctZero;
        private System.Windows.Forms.PictureBox pctThree;
        private System.Windows.Forms.PictureBox pctOne;
    }
}