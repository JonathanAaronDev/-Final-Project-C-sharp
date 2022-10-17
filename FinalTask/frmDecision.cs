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
    public partial class frmDecision : Form
    {
        User player; // User object.
        public frmDecision(Object user)
        {
            InitializeComponent();
            player = user as User; // turn player from object to User type.
        }

        private void pctUpdate_Click(object sender, EventArgs e)
        {

            frmUpdate update = new frmUpdate(player as object); // Create new form.
            update.ShowDialog();
        }

        private void pctTrivia_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("ברוך הבא למשחק.");
            MessageBox.Show("(בחרו כמה שאלות אתם רוצים במשחק(בין 7 ל10.");
            MessageBox.Show("לאחר הבחירה לחצו על כפתור התחל.");
            lblAmount.Visible = true;
            cmbAmount.Visible = true;
            bttBegin.Visible = true;
        }

        private void pctLearning_Click(object sender, EventArgs e)
        {
            frmLearning learn = new frmLearning(player as object); // Create new form.
            learn.ShowDialog();

        }

        private void bttBegin_Click(object sender, EventArgs e)
        {
            if (cmbAmount.SelectedItem == null) // Check if the user told us how many questions.
            {
                MessageBox.Show(".בבקשה בחר את המאפיינים הדרושים לפני שאתה מנסה להתחיל את המשחק");
                return;
            }
            frmTrivia trivia = new frmTrivia(player as object, int.Parse(cmbAmount.Text)); // Create new form.
            this.Hide();
            trivia.ShowDialog();

        }

        private void frmDecision_Load(object sender, EventArgs e)
        {
            MessageBox.Show("שלום");
        }
    }
}
