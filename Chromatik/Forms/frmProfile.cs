using Chromatik.Classes.Token;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Diagnostics.Eventing.Reader;

namespace Chromatik.Forms
{
    public partial class frmProfile : Form
    {
        TextBox tbxNom = new TextBox();
        TextBox tbxPrenom = new TextBox();
        TextBox tbxEmail = new TextBox();
        TextBox tbxTelephone = new TextBox();
        Button btnEnregistrer = new Button();
        User u;
        public frmProfile()
        {
            InitializeComponent();
            u = Storage.getUser();
            InitializeControls();

        }

        private void InitializeControls()
        {
            // Initialize labels
            lblNomModifiable.Size = new Size(154, 20);
            lblPrenomModifiable.Size = new Size(154, 20);
            lblEmailModifiable.Size = new Size(154, 20);
            lblTelephoneModifiable.Size = new Size(154, 20);

            // Initialize buttons
            btnModifier.Location = new Point(408, 347);
            btnModifier.Size = new Size(200, 20);
            btnModifier.Text = "Modify User information";
            btnModifier.Click += btnModifier_Click;

            btnEnregistrer.Size = new Size(154, 20);
            btnEnregistrer.Text = "Save";
            btnEnregistrer.Click += btnEnregistrer_Click;


            lblNomModifiable.Text = u.Name;
            lblPrenomModifiable.Text = u.First_name;
            lblEmailModifiable.Text = u.Email;
            lblTelephoneModifiable.Text = u.Phone_number;


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            SwitchToEditMode();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            var user = Storage.getUser();
            if (user.Name == tbxNom.Text && user.First_name == tbxPrenom.Text && user.Email == tbxEmail.Text && user.Phone_number == tbxTelephone.Text)
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
            // Switch to edit mode
            lblNomModifiable.Visible = false;
            lblPrenomModifiable.Visible = false;
            lblEmailModifiable.Visible = false;
            lblTelephoneModifiable.Visible = false;
            btnModifier.Visible = false;

            tbxNom.Text = lblNomModifiable.Text;
            tbxPrenom.Text = lblPrenomModifiable.Text;
            tbxEmail.Text = lblEmailModifiable.Text;
            tbxTelephone.Text = lblTelephoneModifiable.Text;
            btnEnregistrer.Location = btnModifier.Location;

            tbxNom.Location = lblNomModifiable.Location;
            tbxPrenom.Location = lblPrenomModifiable.Location;
            tbxEmail.Location = lblEmailModifiable.Location;
            tbxTelephone.Location = lblTelephoneModifiable.Location;


            tbxNom.Size = new Size(175, 30);
            tbxPrenom.Size = new Size(175, 30);
            tbxEmail.Size = new Size(175, 30);
            tbxTelephone.Size = new Size(175, 30);

            tbxNom.Visible = true;
            tbxPrenom.Visible = true;
            tbxEmail.Visible = true;
            tbxTelephone.Visible = true;
            btnEnregistrer.Visible = true;

            this.Controls.Add(tbxNom);
            this.Controls.Add(tbxPrenom);
            this.Controls.Add(tbxEmail);
            this.Controls.Add(tbxTelephone);
            this.Controls.Add(btnEnregistrer);
        }

        private void SwitchToViewMode()
        {
            // Switch to view mode
            lblNomModifiable.Text = tbxNom.Text;
            lblPrenomModifiable.Text = tbxPrenom.Text;
            lblEmailModifiable.Text = tbxEmail.Text;
            lblTelephoneModifiable.Text = tbxTelephone.Text;

            tbxNom.Visible = false;
            tbxPrenom.Visible = false;
            tbxEmail.Visible = false;
            tbxTelephone.Visible = false;
            btnEnregistrer.Visible = false;

            lblNomModifiable.Location = tbxNom.Location;
            lblPrenomModifiable.Location = tbxPrenom.Location;
            lblEmailModifiable.Location = tbxEmail.Location;
            lblTelephoneModifiable.Location = tbxTelephone.Location;


            lblNomModifiable.Visible = true;
            lblPrenomModifiable.Visible = true;
            lblEmailModifiable.Visible = true;
            lblTelephoneModifiable.Visible = true;
            btnModifier.Visible = true;
        }

        private void modifyUser()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            string contentType = "application/json";
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
            var consumeApi = client.PutAsJsonAsync($"users/{Storage.getUser().Id}", new { name = tbxNom.Text, first_name = tbxPrenom.Text, phone_number = tbxTelephone.Text, email = tbxEmail.Text });
            consumeApi.Wait();
            var data = consumeApi.Result;
            if (data.IsSuccessStatusCode)
            {
                MessageBox.Show("User modified", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Storage.setUser(
                    new User
                    {
                        Id = Storage.getUser().Id,
                        Name = tbxNom.Text,
                        First_name = tbxPrenom.Text,
                        Email = tbxEmail.Text,
                        Phone_number = tbxTelephone.Text
                    }
             );
            }

        }

    }
}
