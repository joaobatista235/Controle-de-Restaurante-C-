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
    public partial class FormCadastroLogin : Form
    {
        public FormCadastroLogin()
        {
            InitializeComponent();
        }

        internal modelo.usuarios Usuario { get; set; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Usuario = null;
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Usuario == null)
            {
                novo();
            }
            else
            {
                editar();
            }
            this.Dispose();
        }

        private void novo()
        {
            controle.UsuarioDB tabela = new controle.UsuarioDB();

            Usuario = new modelo.usuarios
            {
                cod = tabela.ProximoCodigo(),
                login = txtUsuario.Text,
                senha = controle.Cripto.criptografar(txtSenha.Text),
                email = txtEmail.Text
            };

            tabela.inserir(Usuario);
            MessageBox.Show("Cadastro de login realizado com sucesso!");
        }

        private void editar()
        {
            controle.UsuarioDB tabela = new controle.UsuarioDB();

                Usuario.login = txtUsuario.Text;
                Usuario.senha = controle.Cripto.criptografar(txtSenha.Text);
                Usuario.email = txtEmail.Text;

            tabela.editar(Usuario);
        }

        private void FormCadastroLogin_Load(object sender, EventArgs e)
        {
            if (Usuario != null)
            {
                txtUsuario.Text = Usuario.login;
                try
                {
                    txtSenha.Text = controle.Cripto.decodificar(Usuario.senha);
                }
                catch (Exception)
                {
                    MessageBox.Show("Senha em texto puro. Limpar a senha");
                }
                
                txtEmail.Text = Usuario.email;
            }
        }
    }
}
