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
    public partial class frmQ0Q1 : Form
    {
        QType0 q0;
        object qe;
        QType1 q1;
        public frmQ0Q1(object q)
        {
            InitializeComponent();
            if (q is QType0)
            {
                q0 = q as QType0; // convert
            }
            else
                q1 = q as QType1; // convert
            qe = q;
        }

        private void frmQ0Q1_Load(object sender, EventArgs e)
        {
            if (q0 == null) // Check if we got TypeQ1
            {
                rdbOpt1.Text = q1.Answers[1];
                rdbOpt2.Text = q1.Answers[0];
                rdbOpt3.Text = q1.Answers[2];
                txtQuestion.Text = q1.Text;
            }
            else // We got TypeQ0
            {
                MessageBox.Show("אנא בחר את התשובה הנכונה מתוך הכפתורים סמן אמת או שקר.");
                rdbOpt1.Text = "שקר";
                rdbOpt3.Text = "אמת";
                rdbOpt2.Visible = false;
                txtQuestion.Text = q0.Text;
            }
        }

        private void bttSend_Click(object sender, EventArgs e)
        {
            if (qe is QType1) // Check Type.
            {
                if (rdbOpt2.Checked) // Check if correct answer.
                {
                    MessageBox.Show("תשובה נכונה");
                    this.DialogResult = DialogResult.OK;
                }
                else // Not
                {
                    MessageBox.Show("טעות");
                    this.DialogResult = DialogResult.None;
                }
            }
            else if (qe is QType0) // Check type
            {
                if ((rdbOpt3.Checked && q0.Answer == true) || (rdbOpt1.Checked && q0.Answer == false)) // Check if correct answer.
                {
                    MessageBox.Show("תשובה נכונה");
                    this.DialogResult = DialogResult.OK;
                }
                else // Not
                {
                    MessageBox.Show("טעות");
                    this.DialogResult = DialogResult.None;
                }
            }
            this.Close();
        }
    }
}
