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
    public partial class FrmOrders : Form
    {
        public int idSelectedRowIndex { get; set; }
        public FrmOrders()
        {
            InitializeComponent();
        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (obj, args) => Select();
            worker.RunWorkerCompleted += (onj, args) => LoadData();
            worker.RunWorkerAsync();
        }

        private void LoadData()
        {
            try
            {
                DtOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DtOrders.DataSource = SvcOrder.ListOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void BtnDeleteOrders_Click(object sender, EventArgs e)
        {
            try
            {
                idSelectedRowIndex = Convert.ToInt32(
                DtOrders?
                .Rows[0]?
                .Cells["idDataGridViewTextBoxColumn"]?
                .FormattedValue?
                .ToString() ?? string.Empty);

                if (MessageBox.Show($"Tem certeza que quer deletar a venda \r " +
                    $"Id: {DtOrders.CurrentRow.Cells[0].Value.ToString()}?", "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SvcOrder.DeleteOrder(idSelectedRowIndex))
                    {
                        MessageBox.Show("Venda deletado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar venda", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            FrmNewOrder newOrder = new FrmNewOrder();
            newOrder.Show();
        }

        private void DtOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FrmViewOrder viewOrder = new FrmViewOrder();
                viewOrder.LblId.Text = DtOrders.CurrentRow.Cells[0].Value.ToString();
                viewOrder.LblName.Text = DtOrders.CurrentRow.Cells[2].Value.ToString();
                viewOrder.LblCpf.Text = Convert.ToInt64(DtOrders.CurrentRow.Cells[3].Value.ToString()).ToString(@"000\.000\.000-00");
                viewOrder.lblDate.Text = DtOrders.CurrentRow.Cells[4].Value.ToString();
                viewOrder.LblStatus.Text = DtOrders.CurrentRow.Cells[6].Value.ToString();
                viewOrder.lblTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", DtOrders.CurrentRow.Cells[5].Value.ToString());
                viewOrder.idSelectedOrder = Convert.ToInt32(DtOrders.CurrentRow.Cells[0].Value.ToString());
                viewOrder.Show();
                viewOrder.FormClosed += UpdateCOrderList;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao vizualizar a venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateCOrderList(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void DtOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Double d;
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                Double.TryParse(e.Value.ToString(), out d);

                e.Value = d.ToString(@"000\.000\.000-00");
            }
        }
    }
}
