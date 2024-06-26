﻿using Chromatik.Classes;
using Chromatik.Classes.Token;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Chromatik.Forms
{

    public partial class frmAllStock : Form
    {
        private Dictionary<int, frmStockDetails> detailCommandMap;
        private Dictionary<int, frmUpdateStock> updateStockMap;

        public frmAllStock()
        {
            InitializeComponent();
            detailCommandMap = new Dictionary<int, frmStockDetails>();
            updateStockMap = new Dictionary<int, frmUpdateStock>();
            loadStock();
    
        }
        private void InitializeDataGridView()
        {
            DataGridViewLinkColumn detailsColumn = new DataGridViewLinkColumn();
            detailsColumn.Name = "DetailsStock";
            detailsColumn.HeaderText = "Details";
            detailsColumn.Text = "See Details";
            detailsColumn.UseColumnTextForLinkValue = true;
            dgvStock.Columns.Add(detailsColumn);
            if (Storage.getUser().Role == "manage")
            {
                DataGridViewLinkColumn updateColumn = new DataGridViewLinkColumn();
                updateColumn.Name = "updateStock";
                updateColumn.HeaderText = "Update";
                updateColumn.Text = "Update Stock";
                updateColumn.UseColumnTextForLinkValue = true;
                dgvStock.Columns.Add(updateColumn);


                DataGridViewLinkColumn deleteColumn = new DataGridViewLinkColumn();
                deleteColumn.Name = "deleteStock";
                deleteColumn.HeaderText = "Delete";
                deleteColumn.Text = "Delete Stock";
                deleteColumn.UseColumnTextForLinkValue = true;
                dgvStock.Columns.Add(deleteColumn);

                btnAddStock.Visible = true;
                btnAddStock.Enabled = true;
            }

           
        }
        private void dgvFournitures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int stockId = Convert.ToInt32(dgvStock.Rows[e.RowIndex].Cells["stock_id"].Value);

                // Gérer le clic sur le lien "Voir Détails"
                if (e.ColumnIndex == dgvStock.Columns["DetailsStock"].Index)
                {
                    frmStockDetails detailCommandeForm;
                    if (!detailCommandMap.TryGetValue(stockId, out detailCommandeForm) || detailCommandeForm.IsDisposed)
                    {
                        detailCommandeForm = new frmStockDetails(stockId);
                        detailCommandMap[stockId] = detailCommandeForm;
                    }

                    detailCommandeForm.Show();
                }
                // Gérer le clic sur le lien "Mettre à jour"
                else if (e.ColumnIndex == dgvStock.Columns["updateStock"].Index)
                {
                    frmUpdateStock updateStockForm;
                    if (!updateStockMap.TryGetValue(stockId, out updateStockForm) || updateStockForm.IsDisposed)
                    {
                        updateStockForm = new frmUpdateStock(stockId);
                        updateStockForm.FormClosed += new FormClosedEventHandler(frmUpdateStock_FormClosed);
                        updateStockMap[stockId] = updateStockForm;
                    }

                    updateStockForm.Show();
                }
                else if (e.ColumnIndex == dgvStock.Columns["deleteStock"].Index)
                {
                    if (Stock.deleteStock(stockId))
                    {
                        MessageBox.Show("Stock Deleted","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        loadStock();
                    }
                    else
                    {
                        MessageBox.Show("Stock Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmUpdateStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadStock();
        }
        public void loadStock()
        {
            dgvStock.Columns.Clear();
            List<Stock> stock = Stock.loadStock();
            if (stock != null)
            {
                dgvStock.DataSource = stock;
                

                    foreach (DataGridViewColumn column in dgvStock.Columns)
                {
                    if (column.Name == "Date")
                    {
                        column.Visible = false;
                    }
                    if (column.Name == "Supplier_id")
                    {
                        column.Name = "Supplier";
                    }
                }
                InitializeDataGridView();
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            frmAddStock frm = new frmAddStock();
            frm.ShowDialog();
        }
    }
}
