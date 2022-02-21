using Common;
using System;
using Services;
using System.Windows.Forms;
using System.Globalization;
using System.ComponentModel;

namespace OrderManager.ChildForms
{
    public partial class FrmViewOrder : Form
    {
        public int idSelectedOrder { get; set; }
        public FrmViewOrder()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            for (int i = 0; i < SvcOrder.ListOrderProduct(idSelectedOrder).Count; i++)
            {
                
                ListProducts.Items.Add(SvcOrder.ListOrderProduct(idSelectedOrder)[i]?.Name?.ToString() ?? string.Empty);
                ListProducts.Items.Add(string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", SvcOrder.ListOrderProduct(idSelectedOrder)[i]?.Value?.ToString() ?? string.Empty));
                ListProducts.Items.Add(SvcOrder.ListOrderProduct(idSelectedOrder)[i]?.Quantity.ToString() ?? string.Empty);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            DragForms.ReleaseCapture();
            DragForms.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmViewOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
