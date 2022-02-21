using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManager.ChildForms
{
    public partial class FrmProducts : Form
    {
        public int idSelectedRowIndex { get; set; }
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (obj, args) => Select();
            worker.RunWorkerCompleted += (obj, args) => LoadData();
            worker.RunWorkerAsync();
        }

        private void LoadData()
        {
            DtProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtProducts.DataSource = SvcProduct.ListProduct().ToList();
        }

        private void UpdateCustomerList(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                idSelectedRowIndex = Convert.ToInt32(
                DtProducts?
                .Rows[0]?
                .Cells["idDataGridViewTextBoxColumn"]?
                .FormattedValue?
                .ToString() ?? string.Empty);

                if (MessageBox.Show($"Tem certeza que quer deletar o produto \r " +
                    $"{DtProducts.CurrentRow.Cells[1].Value.ToString()}?", "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SvcProduct.DeleteProduct(idSelectedRowIndex))
                    {
                        MessageBox.Show("Produto deletado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNewProduct_Click(object sender, EventArgs e)
        {
            FrmNewProduct product = new FrmNewProduct();
            product.Show();
            product.FormClosed += UpdateCustomerList;
        }

        private void DtProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SvcProduct.UpdateProduct(
                    Convert.ToInt32(
                DtProducts?.CurrentRow?.Cells[0]?.Value?.ToString() ?? string.Empty),
                DtProducts?.CurrentRow?.Cells[1].Value?.ToString() ?? string.Empty,
                1,
                Convert.ToInt32(DtProducts?.CurrentRow?.Cells[3]?.Value?.ToString() ?? string.Empty),
                DtProducts?.CurrentRow?.Cells[4]?.Value?.ToString().Replace("R$", "").Replace(",", ".") ?? string.Empty
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }
    }
}
