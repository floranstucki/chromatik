using Chromatik.Classes.Token;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

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
            User u = new User
            {
                Name = tbxName.Text,
                First_name = tbxFirstName.Text,
                Phone_number = tbxPhone.Text,
                Email = tbxEmail.Text,
                Password = tbxPassword.Text
            };
            if (string.IsNullOrEmpty(u.Name) || string.IsNullOrEmpty(u.First_name) || string.IsNullOrEmpty(u.Phone_number) || string.IsNullOrEmpty(u.Email) || string.IsNullOrEmpty(u.Password))
            {
                MessageBox.Show("Please fill all the fields");
                
            }
            else if(tbxPassword.Text != tbxConfirmation.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            else
            {
                if (User.registerUser(u))
                {
                    MessageBox.Show("User registered successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occured while registering the user");
                }
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
    }
}
