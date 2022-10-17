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
    public partial class frmAddData : Form
    {
        string name;
        string path;
        Image image;
        bool pic;
        User player;
        public frmAddData(object p) // Constructor
        {
            InitializeComponent();
            pic = false; // Set inital value too false.
            player = p as User; // Convert to user.
        }

        private void frmAddData_Load(object sender, EventArgs e)
        {
            // Set the form look.
            MessageBox.Show("בחר את סוג פריט המידע שברצונך להוסיף.");
            pctAddFile.Visible = false;
            lblExample.Visible = false;
            txtExample.Visible = false;
            txtInfo.Visible = false;
            lblInsert.Visible = false;
            pctInfoWithoutPicture.Visible = true;
            pctInfoWithPicture.Visible = true;
        }

        private void pctInfoWithPicture_Click(object sender, EventArgs e)
        {
            // Set the form look in accordance with user wishes.
            lblExample.Visible = true;
            txtExample.Visible = true;
            pctInfoWithoutPicture.Visible = false;
            pctInfoWithPicture.Visible = false;
            txtExample.Text = "שם צורה; תכונה;";
            txtInfo.Visible = true;
            lblInsert.Visible = true;
            pic = true;
        }

        private void pctAddFile_Click(object sender, EventArgs e)
        {
            // Set the form look in accordance with user wishes.
            ofdAdd = new OpenFileDialog(); // Create open file dialog object.
            ofdAdd.Title = "Open Image file"; // Title.
            ofdAdd.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*"; // Filter users options.
            if (ofdAdd.ShowDialog() == DialogResult.OK) // Check if clicked.
            {
                image = Image.FromFile(ofdAdd.FileName); // Save image.
            }
            name = ofdAdd.FileName; // Save name.
            path = $@"..\\..\\Dimages\\" + Path.GetFileName(ofdAdd.FileName); // Create wanted path.
            File.Copy(ofdAdd.FileName, path); // Move to wanted path.
        }
        // The function retuns string and recives no variable.
        // The aim of the function is to check the text inserted.
        public string TextCheck()
        {
            string text = txtInfo.Text;
            if (!text.Contains(";"))
            {
                throw new ArgumentException("הטקסט שהוכנס אינו עומד בדרישות, אין סימן ';' בין המילים."); // Execption.
            }
            StreamReader file = new StreamReader(@"..\\..\\Data\\infoData.txt"); // Read file.
            string str = null;
            while ((str = file.ReadLine()) != null)
            {
                if (str.Contains(text))
                {
                    throw new ArgumentException("פריט המידע שבחרת להכניס כבר נמצא ברשימה."); // Exception.
                }
            }
            file.Close(); // Close file.
            return text; // Text valid.
        }
        // The function sets the form look to a wanted one.
        public void Set()
        {
            // Set the form look.
            MessageBox.Show("בחר את סוג פריט המידע שברצונך להוסיף.");
            MessageBox.Show("במידה ומדובר בפריט עם תמונה הכנס את הטקסט ולאחר מכן לחץ על אישור על מנת שתוכל להוסיף את התמונה.");
            MessageBox.Show("אחרת הכנס את הטקסט ולחץ על אישור.");
            pctAddFile.Visible = false;
            lblExample.Visible = false;
            txtExample.Visible = false;
            txtInfo.Visible = false;
            lblInsert.Visible = false;
            pctInfoWithoutPicture.Visible = true;
            pctInfoWithPicture.Visible = true;
        }
        // THe function aim is to add the info data to our database.
        private void pctAddtofile_Click(object sender, EventArgs e)
        {
            DataItemWithPicture newadd = null;
            DataItem newadd2 = null;
            string[] a = txtInfo.Text.Split(';');
            string text = "";
            string img;
            string ext = Path.GetExtension(path);
            StreamWriter adding = File.AppendText(@"..\\..\\Data\\infoData.txt"); // Writer object.
            if (pic == true) // check to see if includes image.
            {
                for (int i = 0; i < a.Length; i++) // Collect text needed for the database.
                {
                    text = text + a[i];
                }
                img = $"{DataItem.Num + 1}{a[0]}" + ext; // Create image name to be uniuqe and to be in standard with what you asked for.
                newadd = new DataItemWithPicture(text, img); // Create object.
                File.Copy(path, $@"..\\..\\Dimages\\{img}"); // Copy image with a new name.
                File.Delete(path); // Delete orignal photo after copy.
                adding.WriteLine($"{newadd.Serial};{newadd.Text}; {newadd.Image}"); // Add to data base text.
                player.Info.Add(newadd.Serial, newadd as object); // Add to database dictonary.
                adding.Close(); // Close file.
            }
            else // No picture included.
            {
                foreach (string item in a) // Gather text needed.
                {
                    text = text + item;
                }
                newadd2 = new DataItem(text); // Create new object.
                adding.WriteLine($"{newadd2.Serial}; {newadd2.Text};"); // Add to database text.
                player.Info.Add(newadd2.Serial, newadd2 as object); // Add to user database dictionary.
                adding.Close(); // Close file.
                MessageBox.Show("הפריט התווסף בהצלחח");
            }
            Set();
        }

        private void pctInfoWithoutPicture_Click(object sender, EventArgs e)
        {
            // Set form look.
            lblExample.Visible = true;
            txtExample.Visible = true;
            txtInfo.Visible = true;
            lblInsert.Visible = true;
            txtExample.Text = "שם צורה; תכונה";
            pctInfoWithoutPicture.Visible = false;
            pctInfoWithPicture.Visible = false;
        }

        // A click event to check text.
        private void pctConfirm_Click(object sender, EventArgs e)
        {
            // If the user wants to add a picutre we first need to validate the text in order for us to get the shape name.
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