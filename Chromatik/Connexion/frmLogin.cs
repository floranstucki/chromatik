using Chromatik.MDI;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chromatik
{
    public partial class frmLogin : Form
    {
        string _username; 
        string _password;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _username = tbxUsername.Text;
            _password = tbxPassword.Text;
        }

        private void errorLogin()
        {
            MessageBox.Show("Please enter a valid username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbxPassword.Clear();
            tbxUsername.Clear();
            tbxUsername.Focus();
        }

        

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp frmSU = new frmSignUp();
            frmSU.ShowDialog();
        }
        private void llbForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tbxUsername.Text == string.Empty){ _username = ""; } else { _username = tbxUsername.Text; }
            
            frmForgotPassword frmFP = new frmForgotPassword(_username);
            frmFP.ShowDialog();
        }
    }
}




