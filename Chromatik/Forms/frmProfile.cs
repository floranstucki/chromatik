using Chromatik.Classes.Token;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Chromatik.Forms
{
    public partial class frmProfile : Form
    {
        TextBox tbxName = new TextBox();
        TextBox tbxFirstName = new TextBox();
        TextBox tbxEmail = new TextBox();
        TextBox tbxPhone = new TextBox();
        Button btnSave = new Button();
        User u;
        public frmProfile()
        {
            InitializeComponent();
            u = Storage.getUser();
            initializeControls();

        }

        private void initializeControls()
        {
            // Initialize labels
            lblValueName.Size = new Size(154, 20);
            lblValueFirstName.Size = new Size(154, 20);
            lblValueEmail.Size = new Size(154, 20);
            lblValuePhone.Size = new Size(154, 20);


            btnModify.Text = "Modify User information";
            btnModify.Click += btnModifier_Click;

            btnSave.Size = btnModify.Size;
            btnSave.Text = "Save your informations";
            btnSave.Click += btnEnregistrer_Click;


            lblValueName.Text = u.Name;
            lblValueFirstName.Text = u.First_name;
            lblValueEmail.Text = u.Email;
            lblValuePhone.Text = u.Phone_number;

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            SwitchToEditMode();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            var user = Storage.getUser();
            if (user.Name == tbxName.Text && user.First_name == tbxFirstName.Text && user.Email == tbxEmail.Text && user.Phone_number == tbxPhone.Text)
            {
                SwitchToViewMode();
            }
            else
            {
                modifyUser();
                SwitchToViewMode();
            }
;
        }

        private void SwitchToEditMode()
        {
            var labels = new List<Label> { lblValueName, lblValueFirstName, lblValueEmail, lblValuePhone };
            var textboxes = new List<TextBox> { tbxName, tbxFirstName, tbxEmail, tbxPhone };
            foreach (var label in labels)
            {
                label.Visible = false;
            }
            btnModify.Visible = false;

            for (int i = 0; i < textboxes.Count; i++)
            {
                textboxes[i].Text = labels[i].Text;
                textboxes[i].Location = labels[i].Location;
                textboxes[i].Size = new Size(175, 30);
                textboxes[i].Visible = true;
                this.Controls.Add(textboxes[i]);
            }
            btnSave.Visible = true;
            btnChange.Visible = false;

            if (!this.Controls.Contains(btnSave))
            {
                btnSave.Location = btnModify.Location;
                this.Controls.Add(btnSave);
            }


        }

        private void SwitchToViewMode()
        {
            // Switch to view mode
            var textboxes = new List<TextBox> { tbxName, tbxFirstName, tbxEmail, tbxPhone };
            var labels = new List<Label> { lblValueName, lblValueFirstName, lblValueEmail, lblValuePhone };
            for (int i = 0; i < textboxes.Count; i++)
            {
                labels[i].Text = textboxes[i].Text;
                labels[i].Location = textboxes[i].Location;
                textboxes[i].Visible = false;
                labels[i].Visible = true;
            }
            btnSave.Visible = false;
            btnModify.Visible = true;
            btnChange.Visible = true;

        }

        private void modifyUser()
        {
            u.Name = tbxName.Text;
            u.First_name = tbxFirstName.Text;
            u.Email = tbxEmail.Text;
            u.Phone_number = tbxPhone.Text;
            if (User.updateUser(u))
            {
                MessageBox.Show("User modified", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Storage.setUser(
                    new User
                    {
                        Id = Storage.getUser().Id,
                        Name = tbxName.Text,
                        First_name = tbxFirstName.Text,
                        Email = tbxEmail.Text,
                        Phone_number = tbxPhone.Text
                    }
             );
            }
            else
            {
                MessageBox.Show("Error while modifying user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }
    }
}
