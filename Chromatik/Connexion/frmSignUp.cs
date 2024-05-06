using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chromatik
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this functuion is used to reset all the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    
                    ((TextBox)control).Clear();
                }
            }
        }

        /// <summary>
        /// register an user to the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string _name = tbxName.Text;
            string _firstName = tbxFirstName.Text;
            string _telephone= tbxTelephone.Text;
            string _password = tbxPassword.Text;
            string _confirmPassword= tbxConfirmation.Text;
            string _email = tbxEmail.Text;

            

            if (_name == "" || _firstName == "" || _telephone == "" || _password == "" || _confirmPassword == "" ||  _email == "")
            {
                MessageBox.Show("Please fill in all fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (_password != _confirmPassword)
            {
                MessageBox.Show("Passwords not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
                RegisterUser(_name, _firstName, _telephone, _password, _email);
            }
        }
        /// <summary>
        /// filters characters to numbers and "+" only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
        private async void RegisterUser(string name, string firstname, string tel, string password, string email)
        {

        }
    }
}
