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
    public partial class frmAddType0 : Form
    {
        User player;
        public frmAddType0(object p)
        {
            InitializeComponent();
            player = p as User; // Convert.
        }

        // The function checks if the text is valid.
        public string TextCheck()
        {
            string text = txtQuestion.Text;
            if (!text.Contains(";"))
            {
                throw new ArgumentException("הטקסט שהוכנס אינו עומד בדרישות, אין סימן ';' בין המילים.");
            }
            StreamReader file = new StreamReader(@"..\\..\\Data\\gameData.txt");
            string str = "";
            while ((str = file.ReadLine()) != null)
            {
                if (str.Contains(text))
                {
                    throw new ArgumentException("השאלה שבחרת להכניס כבר נמצאת ברשימה.");
                }
            }
            file.Close();
            return text;
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
                txtQuestion.Clear();
                return;
            }
            if (txtQuestion.Text == null) // No Question enterd.
            {
                MessageBox.Show("לא הוכנסה שאלה");
            }
            if (txtAnswer.Text == null) // No answer enterd.
            {
                MessageBox.Show("לא הוכנסה תשובה");
            }
            bool answer;
            string[] answers = txtAnswer.Text.Split(';');
            if (answers[0] == "שקר") // If the user enterd that שקר is the correct answer set bool answer to it.
            {
                answer = false;
            }
            else
            {
                answer = true; // Oppiste of flase is true.
            }
            string text = txtQuestion.Text; // Get text.
            QType0 question = new QType0(text, 0, answer); // Create object.
            StreamWriter adding = File.AppendText(@"..\\..\\Data\\gameData.txt"); // Writing object.
            adding.WriteLine($"Q{question.Serial};TYPE0;{question.Text};{txtAnswer.Text}"); // Write to data.
            adding.Close();
            player.Questions.Add(question); // Add to user questions pool.
            this.Close();
        }
    }
}
