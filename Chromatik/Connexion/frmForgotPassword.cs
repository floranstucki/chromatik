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
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword(string _username)
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Under Construction !!", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
