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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (obj, args) => Select();
            worker.RunWorkerCompleted += (obj, args) => LoadData();
            worker.RunWorkerAsync();
        }

        private void LoadData()
        {
            try
            {
                DtproductsLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                LblCustomerCount.Text = SvcDashboard.CustumersCount().ToString();
                LblProductsCount.Text = SvcDashboard.ProductsCount().ToString();
                LblOrdersCount.Text = SvcDashboard.OdersCount().ToString();
                LblMoveCount.Text = SvcDashboard.OrderValueCount().ToString();
                DtproductsLowStock.DataSource = SvcDashboard.LowStockProductsCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }
    }
}
