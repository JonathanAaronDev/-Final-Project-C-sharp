using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTask
{
    public partial class frmQ2Q3 : Form
    {
        List<int> save;
        QType2 q2;
        QType3 q3;
        public frmQ2Q3(object q)
        {
            InitializeComponent();
            if (q is QType2)
            {
                q2 = q as QType2;
            }
            else
            {
                q3 = q as QType3;
            }
            save = new List<int>();
        }
        private void frmQ2Q3_Load(object sender, EventArgs e)
        {
            if (q3 == null) // Set form for Q2 type.
            {
                pctOption3.Visible = false;
                pctOption1.Visible = false;
                MessageBox.Show("לפנייך תמונה ושאלה על התמונה, אנא סמן האם התשובה לשאלה היא אמת או שקר.");
                pctOption2.Image = Image.FromFile($@"..\\Qimages\\{q2.Img}"); // Show the question pic.
                txtQuestion.Text = q2.Text;
                rdbOpt3.Visible = false;
                rdbOpt1.Text = "אמת";
                rdbOpt2.Text = "שקר";
            }
            else // Set for Q3 type.
            {
                pctOption3.Visible = true;
                pctOption1.Visible = true;
                rdbOpt3.Visible = true;
                rdbOpt1.Text = "1";
                rdbOpt2.Text = "2";
                rdbOpt3.Text = "3";
                MessageBox.Show("אנא סמן מתחת לתמונה הנכונה.");
                int check;
                Random r = new Random();
                List<int> numbers = new List<int> { 0, 1, 2 };
                string[] img = q3.Picture;
                check = r.Next(0, numbers.Count); // Randomized photo locations before showing user.
                pctOption1.Image = Image.FromFile($@"..\\..\\Qimages\\{img[check]}"); // First photo randomized out of 3
                numbers.Remove(check);
                save.Add(check); // Save the number to use it while checking if correct answer.
                check = r.Next(0, numbers.Count);
                while (!numbers.Contains(check)) // check if we already randomized this number.
                {
                    check = r.Next(0, numbers.Count); // Random again beacuse we already randomed this number.
                }
                numbers.Remove(check); // We randomized this one, no repatitions. 
                pctOption2.Image = Image.FromFile($@"..\\..\\Qimages\\{img[check]}"); // Second ranomized photo.
                save.Add(check);
                pctOption3.Image = Image.FromFile($@"..\\..\\Qimages\\{img[numbers[0]]}"); // Only reamining option.
                save.Add(numbers[0]);
                txtQuestion.Text = q3.Text;
            }
        }

        private void bttSend_Click(object sender, EventArgs e)
        {
            if (q3 == null) // Check if TypeQ2
            {
                if (q2.Answer == false && rdbOpt2.Checked || q2.Answer == true && rdbOpt1.Checked) // Check if correct
                {
                    MessageBox.Show("תשובה נכונה");
                    this.DialogResult = DialogResult.OK;
                }
                else // Wrong
                {
                    MessageBox.Show("טעות");
                    this.DialogResult = DialogResult.None;
                }
            }
            if (q2 == null) // Check if we got TypeQ3
            {
                string img1 = System.IO.Path.GetFileName($@"..\\..\\Qimages\\{q3.Picture[save[0]]}"); // get images
                string img2 = System.IO.Path.GetFileName($@"..\\..\\Qimages\\{q3.Picture[save[1]]}"); // get images
                string img3 = System.IO.Path.GetFileName($@"..\\..\\Qimages\\{q3.Picture[save[2]]}"); // get images
                if (rdbOpt1.Checked && q3.Answer == img1 || rdbOpt2.Checked && q3.Answer == img2 || rdbOpt3.Checked && q3.Answer == img3) // Check if correct.
                {
                    MessageBox.Show("תשובה נכונה");
                    this.DialogResult = DialogResult.OK;
                }
                else // Wrong
                {
                    MessageBox.Show("טעות");
                    this.DialogResult = DialogResult.None;
                }
            }
            this.Hide();
        }
    }
}