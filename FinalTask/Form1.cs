using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTask
{
    public partial class frmLogin : Form
    {
        Dictionary<int, object> data;
        public frmLogin() // Constructor
        {
            InitializeComponent();
            data = new Dictionary<int, object>(); // Intialize dictonary.
        }

        //Picture box of the door click event.
        // The door is a metaphoric replacement to the "enter" button we are used to.
        // Form login function.

        public void CreateDict()
        {
            DataItem data1 = null; // Create temp DataItem object.
            DataItemWithPicture data2 = null;  // Create temp DataItemWithPicture object.
            StreamReader info = new StreamReader(@"..\\..\\Data\\infoData.txt"); // Read file.
            string str = null; // Reader.
            string text = null; // Text of the object
            string[] a; // Array for the text.
            string img = null; // Img path.
            while ((str = info.ReadLine()) != null) // Read file.
            {
                if (str.Contains(".")) // Check to see if it contains '.' to know if its an image type
                {
                    a = str.Split(';'); // Split with ';'.
                    for (int i = 2; i <= a.Length - 2; i++) // Run through the text 
                    {
                        text = text + a[i]; // Add info.
                    }
                    img = a[a.Length - 1]; // Last word is the image.
                    data2 = new DataItemWithPicture(text, img); // Create new object.
                    data.Add(data2.Serial, data2); // Add to Dictonary.
                }
                else // Not an image Data.
                {
                    a = str.Split(';');
                    for (int i = 2; i < a.Length; i++) // Run through the text 
                    {
                        text = text + a[i]; // Add info.
                    }
                    data1 = new DataItem(text); // Create object.
                    data.Add(data1.Serial, data1); // Add to dictonary.
                }
                text = null; // Clear text in order to have a new entry.
            }
            info.Close(); // Close txt file.
                          // The function dosnet recive any variable and is a void function.
                          // The aim of the function is to clear the text boxes to give the user another attempt to login again.
        }
        public void Clean()
        {
            txtMail.Clear();
            txtUserName.Clear();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MessageBox.Show(".ברוך הבא לתוכנה שלנו, אנא הכנס את המייל שלך בשביל להתחבר");
            MessageBox.Show(".מייל תקין אינו מכיל רווחים, הוא מכיל סימן כרוכית ולאחר סימן הכרוכית חייבת להופיע לפחות נקודה אחת");
            MessageBox.Show("אחרי מילוי הפרטים לחץ על הדלת בשביל להיכנס.");
            CreateDict();
        }

        private void pctDoor_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text; // Get the mail the user enterd.
            User user = null; // Create a currently null User object.
            string name = txtUserName.Text; // Get the name the user enterd.
            try // In accordance to your demand we need to validate the mail adress.
            {
                user = new User(txtMail.Text, txtUserName.Text, data); // Create user.
            }
            catch (Exception e2) // Failed.
            {
                MessageBox.Show(e2.Message);
                MessageBox.Show("אנא נסו להתחבר שנית");
                Clean();
                return;
            }
            user.CheckDirectory(); //Check if directory exist.
            user.GetInfo(); // Collect info.
            user.IntializePool();
            MessageBox.Show(".כעת תעברו אל השלב הבא בתוכנה בו עליכם לבחור אחת מבין 3 האופציות המוצגות בפנייך");
            this.Hide(); //Hide current form.
            frmDecision decision = new frmDecision(user as object); // Create 
            decision.ShowDialog();
            this.Close();
        }
    }
}
