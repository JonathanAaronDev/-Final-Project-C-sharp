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
    public partial class frmAddType2 : Form
    {
        User player;
        QType2 q;
        Image image;
        public frmAddType2(object p)
        {
            InitializeComponent();
            player = p as User; // Convert.
            q = null;
        }
        public string TextCheck() // Check text.
        {
            string text = txtQuestion.Text;
            StreamReader file = new StreamReader(@"..\\..\\Data\\gameData.txt");
            string str = null;
            while ((str = file.ReadLine()) != null)
            {
                if (str.Contains(text))
                {
                    throw new ArgumentException("פריט המידע שבחרת להכניס כבר נמצא ברשימה.");
                }
            }
            file.Close();
            return text;
        }

        private void pctAdd_Click(object sender, EventArgs e)
        {
            player.Questions.Add(q); // Add to user pool.
            this.Close();
        }

        private void frmAddType2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("שלום, על מנת להוסיף שאלה מסוג זה עלייך ראשית לשאול שאלה, לתת את התשובה הנכונה(אמת או שקר) ולהוסיף תמונה מתאימה");
            MessageBox.Show("לאחר שייבדק הטקסט שבחרת להוסיף תוכל להוסיף תמונה ולאחר מכן ללחוץ על הפלוס בשביל להוסיף את השאלה");
        }

        private void pctAddPic_Click(object sender, EventArgs e)
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
            if (txtQuestion.Text == null) // No question enterd.
            {
                MessageBox.Show("לא הוכנסה שאלה");
            }
            if (txtAnswer.Text == null) // No answer given.
            {
                MessageBox.Show("לא הוכנסה תשובה");
            }
            bool answer;
            if (txtAnswer.Text == "שקר") // If answer is שקר than set bool to false.
            {
                answer = false;
            }
            else
            {
                answer = false;
            }
            string text = txtQuestion.Text;
            ofdAdd = new OpenFileDialog(); // Create new Object of openfiledialog.
            string [] answers = txtAnswer.Text.Split(';');
            ofdAdd.Title = "Open Image file"; // Title
            ofdAdd.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*"; // Filter.
            if (ofdAdd.ShowDialog() == DialogResult.OK) // Check if clicked.
            {
                image = Image.FromFile(ofdAdd.FileName); // Save image.
            }
            string name = Path.GetFileName(ofdAdd.FileName); // Save name.
            string path = $@"..\\..\\qimages\\" + name; // Create path. 
            File.Copy(ofdAdd.FileName, path); // Save image.
            QType2 question = new QType2(text, 2, answer, Path.GetFileName(ofdAdd.FileName)); // Create object
            StreamWriter adding = File.AppendText(@"..\\..\\Data\\gameData.txt"); // Writer.
            adding.WriteLine($"Q{question.Serial};TYPE2;{question.Text};{answers[0]};{answers[1]};{name}"); // Add to data.
            adding.Close();
            pctAdd.Enabled = true; // Enable clicking on add button.
        }
    }
}
