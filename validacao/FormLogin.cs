using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteDBTA.validacao
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        internal string Usuario { get; set; }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = controle.Cripto.criptografar(txtSenha.Text);

            controle.UsuarioDB login = new controle.UsuarioDB();

            if (login.validar(usuario, senha))
            {
                Usuario = usuario;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Login ou senha inválida");
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Alt || e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }    
        }
    }
}
