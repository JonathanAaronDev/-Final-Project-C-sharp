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
    public partial class frmAddType3 : Form
    {
        string name1;
        string name2;
        string name3;
        User player;
        string path;
        Image image;
        public frmAddType3(object p)
        {
            InitializeComponent();
            player = p as User; // Convert.
        }

        private void pctAddFile_Click(object sender, EventArgs e) // First photo added.
        {
            ofdAdd = new OpenFileDialog(); // New openfiledialog objet.
            ofdAdd.Title = "Open Image file"; // Title.
            ofdAdd.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*"; // Filter.
            if (ofdAdd.ShowDialog() == DialogResult.OK) // Check if clicked.
            {
                image = Image.FromFile(ofdAdd.FileName); // Save photo.
            }
            name1 = $"{Questions.Num}" + "Q1" + Path.GetExtension(ofdAdd.FileName); // Give photo unique name and save it.
            path = $@"..\\..\\Qimages\\" +  name1;
            File.Copy(ofdAdd.FileName, path); // Copy photo with new unique name.
            pctAddFile1.Visible = true; // You can now add next photo.
            pctAddFile.Visible = false;
        }

        private void pctAddFile1_Click(object sender, EventArgs e)
        {
            // Just like previous photo added, same process.
            ofdAdd = new OpenFileDialog();
            ofdAdd.Title = "Open Image file";
            ofdAdd.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            if (ofdAdd.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(ofdAdd.FileName);
            }
            name2 = $"{ Questions.Num}" + "Q2"+Path.GetExtension(ofdAdd.FileName);
            path = $@"..\\..\\Qimages\\" + name2;
            File.Copy(ofdAdd.FileName, path);
            pctAddFile2.Visible = true;
            pctAddFile1.Visible = false;
        }

        private void pctAddFile2_Click(object sender, EventArgs e)
        {
            // Just like previous photo added, same process.
            ofdAdd = new OpenFileDialog();
            ofdAdd.Title = "Open Image file";
            ofdAdd.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            if (ofdAdd.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(ofdAdd.FileName);
            }
            name3 = $"{Questions.Num}" + "Q3" + Path.GetExtension(ofdAdd.FileName);
            path = $@"..\\..\\Qimages\\" +  name3;
            File.Copy(ofdAdd.FileName, path);
            pctAddFile.Visible = true;
            pctAddFile2.Visible = false;
        }
        public string TextCheck() // Check text.
        {
            string text = txtInfo.Text;
            StreamReader file = new StreamReader(@"..\\..\\Data\\gameData.txt");
            string str = null;
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
        private void pctAddtofile_Click(object sender, EventArgs e)
        {
            StreamWriter adding = File.AppendText(@"..\\..\\Data\\gameData.txt"); // Write.
            QType3 question = new QType3(txtInfo.Text, 3, name1, name2, name3); // Create new object
            adding.WriteLine($"Q{question.Serial}; TYPE3;{question.Text}; {question.Picture[0]};{question.Picture[1]};{question.Picture[2]}"); // Add to data.
            player.Questions.Add(question); // Add to user pool.
            adding.Close();
            MessageBox.Show("השאלה הוספה בהצלחה");
        }

        private void frmAddType3_Load(object sender, EventArgs e)
        {

            MessageBox.Show("הכנס טקסט שאלה, לאחר מכן לחץ על אישור ואז הוסף את התמונות שברצונך להוסיף, התמונה הראשונה שתוסיף גם תסומן כתשובה הנכונה.");
            txtExmpale.Text = "לפנייך שלוש תמונות זהה את הריבוע";
        }

        private void pctConfirm_Click(object sender, EventArgs e)
        {
            // Check text before letting user adding photos.
            string add;
            try
            {
                add = TextCheck();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                MessageBox.Show("אנא נסו שוב");
                txtInfo.Clear();
                return;
            }
            pctAddFile.Visible = true;
        }
    }
 }