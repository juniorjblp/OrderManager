using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Services;

namespace OrderManager.ChildForms
{
    public partial class FrmNewProduct : Form
    {
        public FrmNewProduct()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditProduct_Load(object sender, EventArgs e)
        {
            try
            {
                CmbCategory.DataSource = SvcCategory.ListCategory();
                CmbCategory.DisplayMember = "Categoria";
                CmbCategory.ValueMember = "categoryname";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SvcProduct.InsertProduct(
                    TxtProdNome.Text,
                    CmbCategory.SelectedIndex + 1,
                    Convert.ToInt32(TxtProdQuant.Text),
                    TxtProdValor.Text.Replace(",", ".")
                    ))
                {
                    MessageBox.Show("Produto adicionado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEditProduct_MouseDown(object sender, MouseEventArgs e)
        {
            DragForms.ReleaseCapture();
            DragForms.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnNewCategory_Click(object sender, EventArgs e)
        {
            FrmCategory category = new FrmCategory();
            category.Show();
        }
    }
}
