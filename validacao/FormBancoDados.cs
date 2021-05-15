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
    public partial class FormBancoDados : Form
    {
        public FormBancoDados()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            controle.Registro.escrever("restaurante", "servidor", txtServidor.Text);
            controle.Registro.escrever("restaurante", "usuario", txtUsuario.Text);
            controle.Registro.escrever("restaurante", "senha",
                controle.Cripto.criptografar(txtSenha.Text));
            MessageBox.Show("Registro do Mysql criado com sucesso!");
            this.Dispose();
        }
    }
}
