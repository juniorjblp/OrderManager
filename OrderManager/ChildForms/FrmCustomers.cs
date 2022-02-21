using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Data;
using Services;

namespace OrderManager.ChildForms
{
    public partial class FrmCustomers : Form
    {
        public int idSelectedRowIndex { get; set; }
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void ListCustomers()
        {
            try
            {
                DtCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DtCustomers.DataSource = SvcCustomers.ListCustomers();
                DtCustomers.Rows[0].Selected = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (obj, args) => Select();
            worker.RunWorkerCompleted += (obj, args) => ListCustomers();
            worker.RunWorkerAsync();
        }

        private void UpdateCustomerList(object sender, FormClosedEventArgs e)
        {
            ListCustomers();
        }
        private void DtCustomers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SvcCustomers.UpdateCustomer(
                Convert.ToInt32(
                    DtCustomers?.CurrentRow?.Cells[0]?.Value?.ToString() ?? string.Empty),
                DtCustomers?.CurrentRow?.Cells[1].Value?.ToString() ?? string.Empty,
                DtCustomers?.CurrentRow?.Cells[2]?.Value?.ToString() ?? string.Empty,
                DtCustomers?.CurrentRow?.Cells[3]?.Value?.ToString() ?? string.Empty,
                DtCustomers?.CurrentRow?.Cells[4]?.Value?.ToString() ?? string.Empty,
                DtCustomers?.CurrentRow?.Cells[5]?.Value?.ToString() ?? string.Empty
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ListCustomers();
            }
            
        }

        private void DtCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Double d;
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                Double.TryParse(e.Value.ToString(), out d);

                e.Value = d.ToString(@"000\.000\.000-00");
            }
        }

        private void BtnNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNewCustomer newCustomer = new FrmNewCustomer();
                newCustomer.Show();
                newCustomer.FormClosed += UpdateCustomerList;
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            idSelectedRowIndex = Convert.ToInt32(DtCustomers?.CurrentRow?.Cells[0]?.Value?.ToString());

            try
            {
                var customerName = $"{DtCustomers.CurrentRow.Cells[1].Value.ToString()} " + " " +
                                   $"{DtCustomers.CurrentRow.Cells[2].Value.ToString()}";

                if (MessageBox.Show($"Tem deletar o cliente \r {customerName}?", "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SvcCustomers.DeleteCustomer(idSelectedRowIndex))
                    {
                        MessageBox.Show("Cliente deletado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListCustomers();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
