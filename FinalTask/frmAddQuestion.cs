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
    public partial class frmAddQuestion : Form
    {
        User player;
        public frmAddQuestion(object p)
        {
            InitializeComponent();
            player = p as User;
        }

        private void frmAddQuestion_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ברוך הבא, אנא לחץ על המספר שברצונך להוסיף שאלה מסוגו לדף השאלות.");
        }

        private void pctZero_Click(object sender, EventArgs e) // If the user chose to add Type0 question.
        {
            this.Hide();
            frmAddType0 form1 = new frmAddType0(player as object);
            form1.ShowDialog();
            this.Close();
        }

        private void pctOne_Click(object sender, EventArgs e) //  If the user chose to add Type1 question.
        {
            this.Hide();
            frmAddType1 form2 = new frmAddType1(player as object);
            form2.ShowDialog();
            this.Close();
        }

        private void pctTwo_Click(object sender, EventArgs e)  //If the user chose to add Type2 question.
        {
            this.Hide();
            frmAddType2 form3 = new frmAddType2(player as object);
            form3.ShowDialog();
            this.Close();
        }

        private void pctThree_Click(object sender, EventArgs e) // If the user chose to add Type3 question.
        {
            this.Hide();
            frmAddType3 form4 = new frmAddType3(player as object);
            form4.ShowDialog();
            this.Close();
        }
    }
}
