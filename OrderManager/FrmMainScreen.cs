using System;
using System.Windows.Forms;
using Common;
using Data;

namespace OrderManager
{
    public partial class FrmMainScreen : Form
    {
        public FrmMainScreen()
        {
            InitializeComponent();
        }
        #region Open Children Forms
        private void OpenChildForm(object FormChild)
        {
            if (this.PnlContent.Controls.Count > 0)
                this.PnlContent.Controls.RemoveAt(0);

            Form fc = FormChild as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.PnlContent.Controls.Add(fc);
            this.PnlContent.Tag = fc;
            fc.Show();
        }
        #endregion

        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            DragForms.ReleaseCapture();
            DragForms.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MoveIndicator(Control control)
        {
            PBIndicator.Top = control.Top;
            PBIndicator.Height = control.Height;
        }
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            OpenChildForm(new ChildForms.FrmDashboard());
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            OpenChildForm(new ChildForms.FrmCustomers());
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            OpenChildForm(new ChildForms.FrmProducts());
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            OpenChildForm(new ChildForms.FrmOrders());
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);

            if (MessageBox.Show("Tem certeza que deseja se deslogar?", "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnDashboard_Load(object sender, EventArgs e)
        {
            LblName.Text = $@"{User.FirstName} {User.LastName}";
            OpenChildForm(new ChildForms.FrmDashboard());
        }
    }
}
