using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chromatik.Forms
{
    public partial class frmProfil : Form
    {
        TextBox tbxNom = new TextBox();
        TextBox tbxPrenom = new TextBox();
        TextBox tbxUsername = new TextBox();
        TextBox tbxTelephone = new TextBox();
        Button btnEnregistrer = new Button();

        public frmProfil()
        {
            InitializeComponent();
            InitializeControls(); 
        }

        private void InitializeControls()
        {
            // Initialize labels
            lblNomModifiable.Size = new Size(154, 20);
            lblPrenomModifiable.Size = new Size(154, 20);
            lblUsernameModifiable.Size = new Size(154, 20);
            lblTelephoneModifiable.Size = new Size(154, 20);

            // Initialize buttons
            btnModifier.Location = new Point(408, 347);
            btnModifier.Size = new Size(154, 20);
            btnModifier.Text = "Modifier";
            btnModifier.Click += btnModifier_Click;

            btnEnregistrer.Size = new Size(154, 20);
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.Click += btnEnregistrer_Click;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            SwitchToEditMode();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            SwitchToViewMode();
        }

        private void SwitchToEditMode()
        {
            // Switch to edit mode
            lblNomModifiable.Visible = false;
            lblPrenomModifiable.Visible = false;
            lblUsernameModifiable.Visible = false;
            lblTelephoneModifiable.Visible = false;
            btnModifier.Visible = false;

            tbxNom.Text = lblNomModifiable.Text;
            tbxPrenom.Text = lblPrenomModifiable.Text;
            tbxUsername.Text = lblUsernameModifiable.Text;
            tbxTelephone.Text = lblTelephoneModifiable.Text;
            btnEnregistrer.Location = btnModifier.Location;

            tbxNom.Location = lblNomModifiable.Location;
            tbxPrenom.Location = lblPrenomModifiable.Location;
            tbxUsername.Location = lblUsernameModifiable.Location;
            tbxTelephone.Location = lblTelephoneModifiable.Location;

            tbxNom.Visible = true;
            tbxPrenom.Visible = true;
            tbxUsername.Visible = true;
            tbxTelephone.Visible = true;
            btnEnregistrer.Visible = true;

            this.Controls.Add(tbxNom);
            this.Controls.Add(tbxPrenom);
            this.Controls.Add(tbxUsername);
            this.Controls.Add(tbxTelephone);
            this.Controls.Add(btnEnregistrer);
        }

        private void SwitchToViewMode()
        {
            // Switch to view mode
            lblNomModifiable.Text = tbxNom.Text;
            lblPrenomModifiable.Text = tbxPrenom.Text;
            lblUsernameModifiable.Text = tbxUsername.Text;
            lblTelephoneModifiable.Text = tbxTelephone.Text;

            tbxNom.Visible = false;
            tbxPrenom.Visible = false;
            tbxUsername.Visible = false;
            tbxTelephone.Visible = false;
            btnEnregistrer.Visible = false;

            lblNomModifiable.Location = tbxNom.Location;
            lblPrenomModifiable.Location = tbxPrenom.Location;
            lblUsernameModifiable.Location = tbxUsername.Location;
            lblTelephoneModifiable.Location = tbxTelephone.Location;


            lblNomModifiable.Visible = true;
            lblPrenomModifiable.Visible = true;
            lblUsernameModifiable.Visible = true;
            lblTelephoneModifiable.Visible = true;
            btnModifier.Visible = true;
        }



    }
}
