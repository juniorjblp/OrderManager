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

namespace OrderManager
{
    public partial class FrmLoginScreen : Form
    {
        public FrmLoginScreen()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            DragForms.ReleaseCapture();
            DragForms.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Imputs Text Login
        private void TxtLogin_Enter(object sender, EventArgs e)
        {
            if (TxtLogin.Text == "Usuário")
            {
                TxtLogin.Text = "";
            }
        }

        private void TxtLogin_Leave(object sender, EventArgs e)
        {
            if (TxtLogin.Text == "")
            {
                TxtLogin.Text = "Usuário";
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Senha")
            {
                TxtPassword.Text = "";
                TxtPassword.UseSystemPasswordChar = true;
            }

        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Senha";
                TxtPassword.UseSystemPasswordChar = false;
            }
        }
        #endregion Login

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtLogin.Text != "Usuário")
            {
                if (TxtPassword.Text != "Senha")
                {
                    SvcUserLogin user = new SvcUserLogin();
                    var validaLogin = user.LoginUser(TxtLogin.Text, TxtPassword.Text);
                    if (validaLogin == true)
                    {
                        this.Hide();
                        FrmMainScreen frmMainScreen = new FrmMainScreen();
                        frmMainScreen.Show();
                        frmMainScreen.FormClosed += Logout;
                    }
                    else
                    {
                        MessageBox.Show("Nome de usuário ou senha inválidos \nPor favor tente novamente.");
                        TxtPassword.Text = "";
                        TxtPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor digite sua senha");
                }
            }
            else
            {
                MessageBox.Show("Por favor digite seu nome de usuário");
            }
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
