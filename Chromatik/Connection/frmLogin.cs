using System;
using System.Windows.Forms;

namespace Chromatik
{
    public partial class frmLogin : Form
    {
    
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (User.LoginUser(tbxEmail.Text, tbxPassword.Text))
            {
                Close();
            }
            else { 
                   MessageBox.Show("Invalid email or password");
            }
        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp frmSU = new frmSignUp();
            frmSU.ShowDialog();
        }
        private void llbForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmForgotPassword frmFP = new frmForgotPassword(tbxEmail.Text);
            frmFP.ShowDialog();
        }
    }
}




