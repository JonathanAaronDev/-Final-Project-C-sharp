using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTask
{
    public partial class frmEnd : Form
    {
        User player;
        int count;
        List<int> mistake;
        List<object> questions;
        public frmEnd(object p, List<object> q, List<int> mistakes)
        {
            InitializeComponent();
            player = p as User; // Convert.
            questions = q;
            mistake = mistakes;
            count = 1;
        }
        private void pctReturn_Click(object sender, EventArgs e) // User want to return to the decision form.
        {
            MessageBox.Show("בחרת לחזור חזרה למסך הראשי, בהצלחה ולהתראות");
            this.Hide();
            frmDecision formdeicde = new frmDecision(player as object);
            formdeicde.ShowDialog();
            this.Close();
        }

        private void pctAgain_Click(object sender, EventArgs e) // User wish to play again with the same questions.
        {
            MessageBox.Show("בחרת לשחק אותו המשחק מחדש, בהצלחה");
            this.Hide();
            frmTrivia form3 = new frmTrivia(player as object, questions); // Create trivia form with the same questions.
            form3.ShowDialog();
            this.Close();
        }

        private void pctGame_Click(object sender, EventArgs e) // User want to play a new game.
        {
            MessageBox.Show("בחרת לשחק משחק חדש, בהצלחה");
            Pool info = new Pool(); 
            List<object> game = info.ChooseQuestions(player.Questions, questions.Count); // Geenerate new random question list.
            this.Hide();
            frmTrivia form4 = new frmTrivia(player as object, game); // Create new trivia form.
            form4.ShowDialog();
            this.Close();
        }

        private void pctShow_Click(object sender, EventArgs e) // User wish to see the right answers to his mistakes.
        {
            pctAnswer.Visible = false;
            txtAnswer.Visible = true;
            MessageBox.Show("בחרת להציג את השאלות שבהן טעית, בהצלחה");
            if (mistake.Count == 0) // Check if there are any mistakes at all.
            {
                MessageBox.Show("ענית על כל השאלות נכון, אין על מה לחזור. אנא בחר אופציה חדשה.");
                return;
            }
            txtQuestion.Visible = true;
            bttNext.Visible = true;
            txtQuestion.Text = (player.Questions[mistake[0]] as Questions).Text; // Show the question.
            if (player.Questions[mistake[0]] is QType0) // Check question type
            {
                QType0 q = player.Questions[mistake[0]] as QType0;
                if (q.Answer == false) // Show him the right answer in hebrew.
                    txtAnswer.Text = $"התשובה הנכונה הינה שקר";
                else
                    txtAnswer.Text = $"התשובה הנכונה הינה אמת";
                return;
            }
            if (player.Questions[mistake[0]] is QType1) // Check question type
            {
                QType1 q = player.Questions[mistake[0]] as QType1;
                txtAnswer.Text = $"התשובה הנכונה הינה {q.Answers[0]}"; // Show him the right statement.
                return;
            }
            if (player.Questions[mistake[0]] is QType2) // Check question type
            {
                QType2 q = player.Questions[mistake[0]] as QType2;
                if (q.Answer == false) // Show him the right answer in hebrew.
                    txtAnswer.Text = $"התשובה הנכונה הינה שקר"; 
                else
                    txtAnswer.Text = $"התשובה הנכונה הינה אמת";
                return;
            }
            if (player.Questions[mistake[0]] is QType3) // Check question type
            {
                txtAnswer.Visible = false;
                pctAnswer.Visible = true;
                QType3 correct = player.Questions[mistake[0]] as QType3;
                pctAnswer.Image = Image.FromFile($@"..\\..\\Qimages\\{correct.Picture[2]}"); // Show him the right picture.
                return;
            }
            MessageBox.Show("לחץ על כפתור השאלה הבאה בשביל להריץ קדימה לשאלה הבאה שבה טעית.");
        }

        private void pctParctice_Click(object sender, EventArgs e) // The user want to try and answer all of the questions he got wrong before.
        {
            MessageBox.Show("בחרת לשחק מחדש במשחק שמכיל רק את השאלות בהן טעית בעבר, בהצלחה");
            List<int> files = player.GetInfo(); // Gather the user data.
            List<object> forgame = new List<object>();
            for (int i = 0; i < files.Count; i++)
            {
                forgame.Add(player.Questions[files[i]]); // Create him his own question list based on his data.
            }
            this.Hide();
            frmTrivia play = new frmTrivia(player as object, forgame); // Create new trivia form.
            play.ShowDialog();
            this.Close();
        }

        private void frmEnd_Load(object sender, EventArgs e)
        {
            MessageBox.Show("אנא לחץ על התמונה שמתארת את מה שברצונך לעשות");
        }

        private void bttNext_Click(object sender, EventArgs e)
        {
            // Just like previous event but now its repating until the user saw all of his mistakes.
            pctAnswer.Visible = false;
            txtAnswer.Visible = true;
            Questions q;
            q = player.Questions[mistake[count]] as Questions;
            txtQuestion.Text = q.Text;
            if (q is QType0)
            {
                if ((q as QType0).Answer == false)
                {
                    txtAnswer.Text = $"התשובה הנכונה הינה שקר";
                }
                else
                {
                    txtAnswer.Text = $"התשובה הנכונה הינה אמת";
                }
            }
            if (q is QType1)
            {
                txtAnswer.Text = $"התשובה הנכונה היא {(q as QType1).Answers[0]}";
            }
            if (q is QType2)
            {
                if ((q as QType2).Answer == false)
                {
                    txtAnswer.Text = $"התשובה הנכונה הינה שקר";
                }
                else
                {
                    txtAnswer.Text = $"התשובה הנכונה הינה אמת";
                }
            }
            if (q is QType3)
            {
                pctAnswer.Visible = true;
                txtAnswer.Visible = false;
                pctAnswer.Image = Image.FromFile($@"..\\..\\Qimages\\{(q as QType3).Picture[2]}");
            }
            count++;
            if (count == mistake.Count)
            {
                MessageBox.Show("אלו הן כל השאלות בהן טעית");
            }
        }
    }
}