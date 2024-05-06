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
    public partial class frmUpdateStock : Form
    {
        public frmUpdateStock(Tuple<string, string, string, double> fourniture)
        {
            InitializeComponent();
            if (fourniture != null ) { 
            cmbTypeFourniture.Text = fourniture.Item1;
            tbxNom.Text = fourniture.Item1;
            tbxMarque.Text = fourniture.Item2;
            cmbFournisseur.Text = fourniture.Item2;
            cmbCouleur.Items.Add(fourniture.Item3);
            cmbCouleur.Text = fourniture.Item3;
            nudPrix.Value = (Decimal)fourniture.Item4;
        }



        }
    }
}
