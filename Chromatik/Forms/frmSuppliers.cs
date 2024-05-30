using Chromatik.Classes;
using System;
using System.Windows.Forms;

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
            Supplier supplier = new Supplier(tbxSupplier.Text, tbxAddress.Text, tbPhone.Text, tbxNPA.Text, tbxCity.Text, tbxEmail.Text);
            var data = Supplier.storeSupplier(supplier);
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
