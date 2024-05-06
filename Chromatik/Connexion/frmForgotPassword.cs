using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chromatik
{
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword(string _username)
        {
            InitializeComponent();
            tbxUsername.Text = _username;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "" || tbxPassword.Text == "" || tbxConfirmation.Text == "")
            {
                MessageBox.Show("Please enter all your informations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tbxUsername.Text != "" && tbxPassword.Text == tbxConfirmation.Text)
                {

                    MessageBox.Show("Your password has been reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Passwords not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
    }
}
