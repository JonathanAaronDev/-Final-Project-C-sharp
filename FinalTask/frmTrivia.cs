using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTask
{
    public partial class frmTrivia : Form
    {
        int ticks;
        User player;
        List<int> mistakes;
        List<int> numbers;
        List<Questions> pool;
        List<object> game;
        int count;
        int correct;
        Pool pools;
        double score;
        public frmTrivia(object user, List<object> q) // Consturctor.
        {
            InitializeComponent();
            player = user as User; // Convert.
            count = 0; // Set counter to 0.
            mistakes = new List<int>(); // Initailize
            correct = 0; // Set counter to 0.
            pool = new List<Questions>(); // Initailize
            game = q; // Save list.
            numbers = new List<int>(); //Initailize
            foreach (var item in q)
            {
                pool.Add(item as Questions); // Create questions list.
            }
            timGameTIme.Start(); // Start timer.
            ticks = 0; // ticks at 0.
        }
        public frmTrivia(object user, int amount)
        {
            InitializeComponent();
            player = user as User;
            count = 0;
            mistakes = new List<int>();
            correct = 0;
            pools = new Pool();
            pool = new List<Questions>();
            game = pools.ChooseQuestions(player.Questions, amount); // Create random list of quesitons in the deisred size.
            numbers = new List<int>();
            foreach (var item in game)
            {
                pool.Add(item as Questions); // Copy to a questions list.
            }
            timGameTIme.Start();
            ticks = 0;
        }

        private void frmTrivia_Load(object sender, EventArgs e)
        {
            MessageBox.Show("בהצלחה.");
            Play();
        }

        // The function is void without getting variabels.
        // The function aim is to faciltae game play ending.
        public void End()
        {
            timGameTIme.Stop(); // Stop counter.
            string time = DateTime.Now.ToString(); // Get date.
            time = time.Replace(":", "_"); //
            time = time.Replace("/", "-"); //
            time = time.Replace(" ", "T"); // All three to clean date string.
            string user = player.Username + "_" + time; // Create user file name.
            string path = $@"..\\..\\Data\\{player.Mail}\\{user}.txt"; // Path.
            FileStream file = File.Create(path); // Create file.
            file.Close(); // Close
            StreamWriter sw = File.AppendText(path); // Writing.
            sw.WriteLine($":המייל של השחקן הוא {player.Mail}"); //
            sw.WriteLine($"שניות זמן המשחק-{ticks}"); //
            sw.WriteLine($"מספר שאלות במשחק {pool.Count}"); //
            sw.WriteLine($"מספר תשובות נכונות {correct}, מספר תשובות לא נכונות {pool.Count - correct}"); //
            sw.WriteLine($"ניקוד במשחק {score}"); //
            sw.WriteLine("שאלות בהן השחקן טעה"); //
            sw.WriteLine("מספרים"); //
            foreach (var item in mistakes) //
            {
                sw.Write($"{item} "); // Write data to file.
            }
            sw.Close(); // Close.
            EndIt(); 
        }
        // Function is a void one, Faciltate game play.
        public void Play()
        {
            if (pool.Count == count) // Check if the game ended.
            {
                MessageBox.Show("נגמר");
                End();
                return;
            }
            if (pool[count] is QType0 || pool[count] is QType1) // Check type.
            {
                frmQ0Q1 q = new frmQ0Q1(pool[count] as object); // Create form.
                q.ShowDialog(); 
                if (q.DialogResult == DialogResult.OK) // Check if correct answer.
                {
                    score = score + 100 / pool.Count; // Give points.
                    correct++; // Increase correct counter.
                }
                else
                {
                    mistakes.Add(pool[count].Serial); // Wrong answer.
                }
            }
            if (pool[count] is QType2 || pool[count] is QType3)
            {
                frmQ2Q3 q1 = new frmQ2Q3(pool[count] as object); // Create new form.
                q1.ShowDialog();
                if (q1.DialogResult == DialogResult.OK) // Check if correct answer.
                {
                    score = score + 100 / pool.Count; // points.
                    correct++; // increase corrects count
                }
                else
                {
                    mistakes.Add(pool[count].Serial); // Wrong one.
                }
            }
            count++; // Increase counter.
            txtPoints.Text = $"הניקוד הנוכחי שלך הוא : {score}";
            txtTime.Text = $"הזמן שעבר עד כה : {ticks}";
            txtAmount.Text = $"מספר שאלות עד כה: {count}";
            txtCorrect.Text = $"מספר תשובות נכונות עד כה: {correct}";
        }

        private void bttSend_Click(object sender, EventArgs e)
        {
            Play();
        }
        public void EndIt()
        {
            this.Hide();
            frmEnd form1 = new frmEnd(player as object, game, mistakes); // Create new form.
            form1.ShowDialog();
        }

        private void timGameTIme_Tick(object sender, EventArgs e) // Timer event.
        {
            ticks++;
        }
    }
}