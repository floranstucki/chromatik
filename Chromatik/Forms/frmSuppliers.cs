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
using Chromatik.Classes;
using Chromatik.Classes.Token;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Chromatik.Forms
{
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier(tbxSupplier.Text, tbxAddress.Text, tbPhoneNumber.Text, tbxNPA.Text, tbxCity.Text, tbxEmail.Text);
            var data = Supplier.AddSupplier(supplier);
            if (data)
            {
                MessageBox.Show("Supplier added successfully", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error while adding supplier", "Error !",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
    }
}
