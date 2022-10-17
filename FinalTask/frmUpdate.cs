using System;
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
    public partial class frmUpdate : Form
    {
        User player;
        public frmUpdate(object p) // Constructor.
        {
            InitializeComponent();
            player = p as User; // convert.
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            MessageBox.Show("בחר האם ברצונך להוסיף פריט לשאלות הטריוויה או פריט לחלק הלימודי.");
            MessageBox.Show("להוספת פריט טריוויה אנא לחצו על תמונת הספינקס, להוספת פריט לימודי אנא לחצו על האדם החושב של רודן.");
        }

        private void pctAddInfo_Click(object sender, EventArgs e) // User Decided to add an eductional information.
        {
            this.Hide(); // Hide.
            frmAddData add = new frmAddData(player as object); // Create new form.
            add.ShowDialog(); // Open new form.
            this.Close(); // Close current form.
        }

        private void pctAddQuestion_Click(object sender, EventArgs e)
        { 
            this.Hide(); // Hide.
            frmAddQuestion add = new frmAddQuestion(player as object); // Create new form.
            add.ShowDialog(); // Open new form.
            this.Close(); // Close current form.
        }
    }
}