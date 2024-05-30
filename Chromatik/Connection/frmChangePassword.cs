using Chromatik.Classes.Token;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Chromatik
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
            tbxEmail.Text = Storage.getUser().Email;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (BCrypt.Net.BCrypt.Verify(tbxOldPassword.Text, Storage.getUser().Password))
            {
                if (tbxPassword.Text == tbxConfirmation.Text)
                {
                    Storage.getUser().Password = tbxPassword.Text;
                    if (User.updateUser(Storage.getUser()))
                    {
                        MessageBox.Show("Password updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Problem with the updating of the password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Your previous password is incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

