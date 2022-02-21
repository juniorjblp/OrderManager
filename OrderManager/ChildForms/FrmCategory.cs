using Common;
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
    public partial class FrmCategory : Form
    {
        public int idSelectedRowIndex { get; set; }
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            ListCategory();
        }

        private void ListCategory()
        {
            DtCategory.DataSource = SvcCategory.ListCategory();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idSelectedRowIndex = Convert.ToInt32(
                DtCategory?
                .Rows[e.RowIndex]?
                .Cells["idDataGridViewTextBoxColumn"]?
                .FormattedValue?
                .ToString() ?? string.Empty);
                BtnEdit.Visible = true;
                BtnDelete.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmCategory_MouseDown(object sender, MouseEventArgs e)
        {
            DragForms.ReleaseCapture();
            DragForms.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TxtFirstName.Text = DtCategory.CurrentRow.Cells[1].Value.ToString();
            BtnSave.Visible = false;
            BtnUpdate.Visible = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Tem deletar o cliente \r {DtCategory.CurrentRow.Cells[1].Value.ToString()}?", "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SvcCategory.DeleteCategory(idSelectedRowIndex))
                    {
                        MessageBox.Show("Categoria deletado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BtnEdit.Visible = false;
                        BtnDelete.Visible = false;

                        ListCategory();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtFirstName.Text))
            {
                MessageBox.Show("Nome da categoria deve ser preenchido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (SvcCategory.UpdateCategory(idSelectedRowIndex, TxtFirstName.Text))
                    {
                        MessageBox.Show("Categoria atualizado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ListCategory();
                BtnSave.Visible = true;
                BtnUpdate.Visible = false;
            }
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtFirstName.Text))
            {
                MessageBox.Show("Nome da categoria deve ser preenchido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (SvcCategory.InsertCategory
                        (
                            TxtFirstName.Text
                        )
                    )
                    {
                        TxtFirstName.Text = "";

                        MessageBox.Show("Categoria adicionado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao adicionar categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ListCategory();
            }      
        }
    }
}
