using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTask
{
    public partial class frmAddType1 : Form
    {
        User player;
        public frmAddType1(object p)
        {
            InitializeComponent();
            player = p as User; // Convert.
        }

        // Check if text is valid.
        public string TextCheck()
        {
            string texta = txtAnswer.Text;
            if (!texta.Contains(";"))
            {
                throw new ArgumentException("הטקסט שהוכנס אינו עומד בדרישות, אין סימן ';' בין המילים.");
            }
            string textq = txtQuestion.Text;
            StreamReader file = new StreamReader(@"..\\..\\Data\\gameData.txt");
            string str = null;
            while ((str = file.ReadLine()) != null)
            {
                if (str.Contains(textq))
                {
                    throw new ArgumentException("פריט המידע שבחרת להכניס כבר נמצא ברשימה.");
                }
            }
            file.Close();
            return textq;
        }

        private void pctAdd_Click(object sender, EventArgs e)
        {
            string add;
            try
            {
                add = TextCheck();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                MessageBox.Show("אנא נסו שוב");
                txtQuestion.Clear();
                return;
            }
            if (txtQuestion.Text == null)
            {
                MessageBox.Show("לא הוכנסה שאלה"); // No question enterd.
            }
            if (txtAnswer.Text == null)
            {
                MessageBox.Show("לא הוכנסה תשובה"); // No answers given.
            }
            string text = txtQuestion.Text;
            string[] a; // Store user answers.
            a = txtAnswer.Text.Split(';'); // split answers to 3.
            QType1 question = new QType1(text, 1, a[0], a[1], a[2]); // Create new object.
            StreamWriter adding = File.AppendText(@"..\\..\\Data\\gameData.txt"); // Writer.
            adding.WriteLine("");
            adding.WriteLine($"Q{question.Serial}; TYPE1; {question.Text};{question.Answers[0]};{question.Answers[1]};{question.Answers[2]}"); // Write to data. 
            adding.Close();
            player.Questions.Add(question); // Add to user questions pool
            this.Close();
        }
    }
}