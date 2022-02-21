using Data;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManager.ChildForms
{
    public partial class FrmNewOrder : Form
    {
        List<Product> listProducts = new List<Product>();
        public int idSelectedRowIndex { get; set; }
        public int idSelectedRowIndexProduct { get; set; }
        public double valueSelectedRowIndexProduct { get; set; }
        public FrmNewOrder()
        {
            InitializeComponent();
        }

        private void FrmNewOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DtProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtProducts.MultiSelect = true;
            DtCustomers.DataSource = SvcCustomers.ListCustomers();
            DtProducts.DataSource = SvcProduct.ListProduct();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listProducts.Count; i++)
                {
                    SvcOrder.InsertProductOrder(idSelectedRowIndex, idSelectedRowIndexProduct);
                }

                if (SvcOrder.InsertOrder(idSelectedRowIndex, idSelectedRowIndexProduct, 1))
                {

                    MessageBox.Show("Venda adicionada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar venda", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void DtCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idSelectedRowIndex = Convert.ToInt32(
                DtCustomers?
                .Rows[e.RowIndex]?
                .Cells["idDataGridViewTextBoxColumn"]?
                .FormattedValue?
                .ToString() ?? string.Empty);
                BtnSalvar.Visible = true;
                BtnCancelar.Visible = true;

                LblName.Text = DtCustomers?.CurrentRow?.Cells[1]?.Value?.ToString() ?? string.Empty;
                LblCpf.Text = Convert.ToInt64(DtCustomers?.CurrentRow?.Cells[2]?.Value?.ToString() ?? string.Empty).ToString(@"000\.000\.000-00");

            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DtProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idSelectedRowIndexProduct = Convert.ToInt32(
                DtProducts?
                .Rows[e.RowIndex]?
                .Cells["idDataGridViewTextBoxColumn1"]?
                .FormattedValue?
                .ToString() ?? string.Empty);
                BtnSalvar.Visible = true;
                BtnCancelar.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    Name = DtProducts.CurrentRow.Cells[1].Value.ToString(),
                    Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", DtProducts.CurrentRow.Cells[4].Value.ToString()),
                    Quantity = Convert.ToInt32(LblQuantity.Text)
                };
                listProducts.Add(product);

                
                    ListProducts.Items.Add(product?.Name ?? string.Empty);
                    ListProducts.Items.Add(product?.Value ?? string.Empty);
                    ListProducts.Items.Add(product?.Quantity.ToString() ?? string.Empty);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cliente, um produto \re preencha a quantidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
