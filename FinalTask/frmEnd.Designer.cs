
namespace FinalTask
{
    partial class frmEnd
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
            this.bttNext = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblCorrectPicture = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAgain = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNewGame = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.pctAnswer = new System.Windows.Forms.PictureBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.pctParctice = new System.Windows.Forms.PictureBox();
            this.pctReturn = new System.Windows.Forms.PictureBox();
            this.pctAgain = new System.Windows.Forms.PictureBox();
            this.pctShow = new System.Windows.Forms.PictureBox();
            this.pctGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctParctice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGame)).BeginInit();
            this.SuspendLayout();
            // 
            // bttNext
            // 
            this.bttNext.Location = new System.Drawing.Point(318, 117);
            this.bttNext.Name = "bttNext";
            this.bttNext.Size = new System.Drawing.Size(103, 46);
            this.bttNext.TabIndex = 34;
            this.bttNext.Text = "שאלה הבאה";
            this.bttNext.UseVisualStyleBackColor = true;
            this.bttNext.Visible = false;
            this.bttNext.Click += new System.EventHandler(this.bttNext_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(81, 20);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(91, 20);
            this.lblAnswer.TabIndex = 33;
            this.lblAnswer.Text = "תשובה נכונה";
            this.lblAnswer.Visible = false;
            // 
            // lblCorrectPicture
            // 
            this.lblCorrectPicture.AutoSize = true;
            this.lblCorrectPicture.Location = new System.Drawing.Point(331, 20);
            this.lblCorrectPicture.Name = "lblCorrectPicture";
            this.lblCorrectPicture.Size = new System.Drawing.Size(87, 20);
            this.lblCorrectPicture.TabIndex = 32;
            this.lblCorrectPicture.Text = "תמונה נכונה";
            this.lblCorrectPicture.Visible = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(562, 15);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(48, 20);
            this.lblQuestion.TabIndex = 31;
            this.lblQuestion.Text = "שאלה";
            this.lblQuestion.Visible = false;
            // 
            // lblAgain
            // 
            this.lblAgain.AutoSize = true;
            this.lblAgain.Location = new System.Drawing.Point(344, 166);
            this.lblAgain.Name = "lblAgain";
            this.lblAgain.Size = new System.Drawing.Size(200, 20);
            this.lblAgain.TabIndex = 30;
            this.lblAgain.Text = "משחק חדש עם אותן השאלות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "תרגול שאלות שטעית בהם בעבר";
            // 
            // lblNewGame
            // 
            this.lblNewGame.AutoSize = true;
            this.lblNewGame.Location = new System.Drawing.Point(523, 301);
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Size = new System.Drawing.Size(127, 20);
            this.lblNewGame.TabIndex = 28;
            this.lblNewGame.Text = "משחק חדש לגמרי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "הראה תשובות נכונות";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(648, 149);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(132, 20);
            this.lblReturn.TabIndex = 26;
            this.lblReturn.Text = "חזרה למסך הראשי";
            // 
            // pctAnswer
            // 
            this.pctAnswer.Location = new System.Drawing.Point(318, 51);
            this.pctAnswer.Name = "pctAnswer";
            this.pctAnswer.Size = new System.Drawing.Size(100, 50);
            this.pctAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAnswer.TabIndex = 25;
            this.pctAnswer.TabStop = false;
            this.pctAnswer.Visible = false;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(452, 38);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(258, 63);
            this.txtQuestion.TabIndex = 24;
            this.txtQuestion.Visible = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(21, 51);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(258, 50);
            this.txtAnswer.TabIndex = 23;
            this.txtAnswer.Visible = false;
            // 
            // pctParctice
            // 
            this.pctParctice.Image = global::FinalTask.Properties.Resources.Again;
            this.pctParctice.Location = new System.Drawing.Point(176, 331);
            this.pctParctice.Name = "pctParctice";
            this.pctParctice.Size = new System.Drawing.Size(153, 105);
            this.pctParctice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctParctice.TabIndex = 22;
            this.pctParctice.TabStop = false;
            this.pctParctice.Click += new System.EventHandler(this.pctParctice_Click);
            // 
            // pctReturn
            // 
            this.pctReturn.Image = global::FinalTask.Properties.Resources.Hoove;
            this.pctReturn.Location = new System.Drawing.Point(636, 172);
            this.pctReturn.Name = "pctReturn";
            this.pctReturn.Size = new System.Drawing.Size(144, 104);
            this.pctReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctReturn.TabIndex = 21;
            this.pctReturn.TabStop = false;
            this.pctReturn.Click += new System.EventHandler(this.pctReturn_Click);
            // 
            // pctAgain
            // 
            this.pctAgain.Image = global::FinalTask.Properties.Resources.Einstein;
            this.pctAgain.Location = new System.Drawing.Point(361, 189);
            this.pctAgain.Name = "pctAgain";
            this.pctAgain.Size = new System.Drawing.Size(156, 109);
            this.pctAgain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAgain.TabIndex = 20;
            this.pctAgain.TabStop = false;
            this.pctAgain.Click += new System.EventHandler(this.pctAgain_Click);
            // 
            // pctShow
            // 
            this.pctShow.Image = global::FinalTask.Properties.Resources.AllTheAnswers;
            this.pctShow.Location = new System.Drawing.Point(85, 166);
            this.pctShow.Name = "pctShow";
            this.pctShow.Size = new System.Drawing.Size(162, 110);
            this.pctShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctShow.TabIndex = 19;
            this.pctShow.TabStop = false;
            this.pctShow.Click += new System.EventHandler(this.pctShow_Click);
            // 
            // pctGame
            // 
            this.pctGame.Image = global::FinalTask.Properties.Resources.Game1;
            this.pctGame.Location = new System.Drawing.Point(529, 324);
            this.pctGame.Name = "pctGame";
            this.pctGame.Size = new System.Drawing.Size(121, 101);
            this.pctGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGame.TabIndex = 18;
            this.pctGame.TabStop = false;
            this.pctGame.Click += new System.EventHandler(this.pctGame_Click);
            // 
            // frmEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalTask.Properties.Resources.shape11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttNext);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblCorrectPicture);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblAgain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNewGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.pctAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.pctParctice);
            this.Controls.Add(this.pctReturn);
            this.Controls.Add(this.pctAgain);
            this.Controls.Add(this.pctShow);
            this.Controls.Add(this.pctGame);
            this.Name = "frmEnd";
            this.Text = "סוף המשחק";
            this.Load += new System.EventHandler(this.frmEnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctParctice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttNext;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblCorrectPicture;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAgain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.PictureBox pctAnswer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.PictureBox pctParctice;
        private System.Windows.Forms.PictureBox pctReturn;
        private System.Windows.Forms.PictureBox pctAgain;
        private System.Windows.Forms.PictureBox pctShow;
        private System.Windows.Forms.PictureBox pctGame;
    }
}