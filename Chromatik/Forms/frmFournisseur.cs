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
    public partial class frmFournisseur : Form
    {
        public frmFournisseur()
        {
            InitializeComponent();
        }

        private void tbxNPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fournisseur Ajouté","Confirmation", MessageBoxButtons.OK,MessageBoxIcon.Information);
            Clear();
        }
        private void Clear() { 
        
            tbxFournisseur.Text = "";
            tbxAdresse.Text = "";
            tbxNPA.Text = "";
            tbxVille.Text = "";
            tbxTelephone.Text = "";
        }

        private void tbxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
    }
}
