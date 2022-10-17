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
    public partial class frmLearning : Form
    {
        int count;
        List<int> numbers; // List of numbers to random from.
        User student;
        public frmLearning(object user) // Constructor.
        {
            InitializeComponent();
            count = 0;
            student = user as User; // Save.
            numbers = new List<int>(); // Initate.
        }

        private void frmLearning_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= student.Info.Count(); i++) // Generate list numbers.
            {
                numbers.Add(i); // Add.
            }
            MessageBox.Show("ברוך הבא לחלק הלימודי שלנו, בשביל לעבור לעובדה הבאה אנא לחצו על התמרור המשך.");
            MessageBox.Show("לפי דרישות המערכת לאחר שתצפו בלפחות 12 פריטים תוכלו לצאת מהחלק הלימודי, אם ברצונכם לצאת לפני סיום החלק הלימודי לחצו על תמרור העצור.");

        }

        private void pctContinue_Click(object sender, EventArgs e)
        {
            lblCounter.Text = $"פריט מספר {count + 1}."; // Lets the user know which num of info we are on.
            Random random = new Random(); // Generate random object.
            if (count == student.Info.Count) // Check if we showed the user all of the info data we have.
            {
                MessageBox.Show("סיימת את החלק הלימודי");
                this.Hide(); // Hide current form.
                frmDecision decision = new frmDecision(student as object); // Create new form.
                decision.ShowDialog(); // Show the new form.
                this.Close(); // Close the file.
            }
            if (count >= 12) // Check if user watched more than 12 data items.
                pctStop.Enabled = true; // Enable our stop button to get out.
            int r = random.Next(1, student.Info.Count + 1); // Random a number.
            while (!numbers.Contains(r)) // check if we already randomized this number.
            {
                r = random.Next(1, student.Info.Count + 1); // Random again beacuse we already randomed this number.
            }
            numbers.Remove(r); // Remove the number we randomized beacuse we need to keep tracked on the numbers we randomized. 
            if (student.Info[r] is DataItemWithPicture) // Check if we randomized an information data with picture.
            {
                DataItemWithPicture temp = student.Info[r] as DataItemWithPicture; // Convert DataItem to DataItemWithPicture.
                txtInfo.Text = temp.Text;  // Show Text.
                pctShape.Visible = true; // Show picture.
                if (temp.Serial <= 30)
                {
                    pctShape.Image = Image.FromFile($@"..\\..\\Dimages\\{temp.Image}"); // Put my picture.
                }
                else
                {
                    string img = "";
                    for (int i = temp.Image.Length - 1; i == 0; i--)
                    {
                        img = img + temp.Image[i];
                    }
                    pctShape.Image = Image.FromFile($@"..\\..\\Dimages\\{temp.Image}"); // Put my picture.
                }
            }
            else // DataItem.
            {
                pctShape.Visible = false; // No picture.
                DataItem temp = student.Info[r] as DataItem;
                txtInfo.Text = temp.Text;
            }
            count++;
        }

        private void pctStop_Click(object sender, EventArgs e) // Decided to stop in the middle.
        {
            MessageBox.Show("בחרתם לעצור את החלק הלימודי, כעת תוכלו לבחור אופציה חדשה.");
            this.Hide();
            frmDecision decision = new frmDecision(student as object);
            decision.ShowDialog();
            this.Close();
        }
    }
}