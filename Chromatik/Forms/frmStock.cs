using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chromatik.Forms
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
            AddData();

        }


        private void AddData()
        {
            cmbTypeFourniture.Items.Add("Peinture");
            cmbTypeFourniture.Items.Add("Pinceau");
            cmbTypeFourniture.Items.Add("Toile");
            cmbTypeFourniture.Items.Add("Palette");

            cmbFournisseur.Items.Add("Le Géant des Beaux-Arts");
            cmbFournisseur.Items.Add("Sennelier");
            cmbFournisseur.Items.Add("Winsor & Newton");
            cmbFournisseur.Items.Add("Lefranc & Bourgeois");

            cmbCouleur.DataSource = typeof(Color).GetProperties()
            .Where(x => x.PropertyType == typeof(Color))
            .Select(x => x.GetValue(null)).ToList();
            cmbCouleur.DrawItem += cmbCouleur_DrawItem;
        }


        //This function is used to draw the color in the combobox
        private void cmbCouleur_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = cmbCouleur.GetItemText(cmbCouleur.Items[e.Index]);
                var color = (Color)cmbCouleur.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cmbCouleur.Font, r2,
                    cmbCouleur.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fourniture ajoutée", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void Clear()
        {
            tbxNom.Text = "";
            tbxMarque.Text = "";
            cmbTypeFourniture.SelectedIndex = -1;
            cmbFournisseur.SelectedIndex = -1;
            cmbCouleur.SelectedIndex = -1;
            nudNombre.Value = 1;
            nudPrix.Value = 1;
        }
    }
}
