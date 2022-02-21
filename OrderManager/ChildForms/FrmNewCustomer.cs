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
using Data;
using Services;

namespace OrderManager.ChildForms
{
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (SvcCustomers.InsertCustomer(
                        TxtFirstName.Text,
                        TxtLastName.Text,
                        TxtCpf.Text.Replace(",", "").Replace(".", "").Replace("-", ""),
                        DtpkrBirthdate.Text,
                        TxtEmail.Text
                    ))
                {
                    MessageBox.Show("Cliente adicionado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEditCustomer_MouseDown(object sender, MouseEventArgs e)
        {
            DragForms.ReleaseCapture();
            DragForms.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
