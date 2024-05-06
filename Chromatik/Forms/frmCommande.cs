using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chromatik
{
    public partial class frmCommande : Form
    {
        public frmCommande()
        {
            InitializeComponent();
            AddData();
        }

        private void cmbTypeFourniture_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTypeFourniture.Text) { 
            
                case "Peinture":
                    cmbFourniture.Items.Clear();
                    cmbFourniture.Items.Add("Huile");
                    cmbFourniture.Items.Add("Acrylique");
                    cmbFourniture.Items.Add("Aquarelle");
                    break;
                case "Pinceau":
                    cmbFourniture.Items.Clear();
                    cmbFourniture.Items.Add("Rond");
                    cmbFourniture.Items.Add("Plat");
                    cmbFourniture.Items.Add("Eventail");
                    break;
                case "Toile":
                    cmbFourniture.Items.Clear();
                    cmbFourniture.Items.Add("Coton");
                    cmbFourniture.Items.Add("Lin");
                    cmbFourniture.Items.Add("Synthétique");
                    break;
                case "Palette":
                    cmbFourniture.Items.Clear();
                    cmbFourniture.Items.Add("Bois");
                    cmbFourniture.Items.Add("Plastique");
                    cmbFourniture.Items.Add("Verre");
                    break;  
            }
        }

        private void btnAjoutPanier_Click(object sender, EventArgs e)
        {
            cmbTypeFourniture.Text = "";
            cmbFourniture.Text = "";
            nudQuantite.Value = 1;
        }

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

        private void AddData()
        {
            cmbTypeFourniture.Items.Add("Peinture");
            cmbTypeFourniture.Items.Add("Pinceau");
            cmbTypeFourniture.Items.Add("Toile");
            cmbTypeFourniture.Items.Add("Palette");

            cmbCouleur.DataSource = typeof(Color).GetProperties()
           .Where(x => x.PropertyType == typeof(Color))
           .Select(x => x.GetValue(null)).ToList();
            cmbCouleur.DrawItem += cmbCouleur_DrawItem;
        }
    }
}
