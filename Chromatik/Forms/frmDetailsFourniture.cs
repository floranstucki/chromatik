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
    public partial class frmDetailsFourniture : Form
    {
        private Tuple<string, string, string, double> _map;
        public frmDetailsFourniture(Tuple<string, string, string, double> Fourniture)
        {
            InitializeComponent();
            _map = Fourniture;
            lblDetail.Text += Fourniture.Item1;
        }

        private void AjouterDetails()
        {
            switch (_map.Item1) {

                case "Gomme":
                       tbxFourniture.Text = _map.Item1 + " de la marque " + _map.Item2 + " \r\n couleur "+_map.Item3 +" Prix : "+ _map.Item4 + "CHF par " + _map.Item1;
                    break;                                                                                                   
                case "Crayon":                                                                                               
                    tbxFourniture.Text = _map.Item1 + " de la marque " + _map.Item2 + " \r\n couleur " + _map.Item3 + " Prix : " + _map.Item4 + "CHF par " + _map.Item1;
                    break;                                                                                                   
                case "Stylo":                                                                                                
                    tbxFourniture.Text = _map.Item1 + " de la marque " + _map.Item2 + " \r\n couleur " + _map.Item3 + " Prix : " + _map.Item4 + "CHF par " + _map.Item1;
                    break;                                                                                                   
                case "Peinture Aquarelle":                                                                                   
                    tbxFourniture.Text = _map.Item1 + " de la marque " + _map.Item2 + " \r\n couleur " + _map.Item3 + " Prix : " + _map.Item4 + "CHF par " + _map.Item1;
                    break;                                                                                                   
                case "Toile en Lin":                                                                                         
                    tbxFourniture.Text = _map.Item1 + " de la marque " + _map.Item2 + " \r\n couleur " + _map.Item3 + " Prix : " + _map.Item4 + "CHF par " + _map.Item1;
                    break;
            }
        }

        private void frmDetailsFourniture_Load(object sender, EventArgs e)
        {
            AjouterDetails();   
        }

        private void btnFavoris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aticle ajouté aux favoris !", "Réussite !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
