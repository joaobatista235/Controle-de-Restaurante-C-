using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteDBTA.visao
{
    public partial class FormFichaProduto : Form
    {

        internal modelo.produto Registro { get; set; }

        public FormFichaProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validacao() == false) return;

            if (Registro == null) novo();
            else editar();
        }

        private bool validacao()
        {
            if (txtDescricao.Text.Equals(""))
            {
                errorProvider1.SetIconPadding(txtDescricao, -20);
                errorProvider1.SetError(txtDescricao, "Descrição está em branco");

                return false;
            }
            else
            {
                errorProvider1.SetError(txtDescricao, string.Empty);
            }


            try
            {
                 double num = Double.Parse(txtPreco.Text, NumberStyles.Currency);
                 errorProvider1.SetError(txtPreco, string.Empty);
            }
            catch (Exception)
            {
                errorProvider1.SetIconPadding(txtPreco, -20);
                errorProvider1.SetError(txtPreco, "Preço inválido");
                return false;
            }

            return true;
        }

        private void novo()
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();

            Registro = new modelo.produto
            {
                nome = txtDescricao.Text.ToUpper(),
                preco = Double.Parse(txtPreco.Text,NumberStyles.Currency),
                idtipo = Convert.ToInt16 (cbCategoria.SelectedValue),
                idproduto = tabela.ProximoCodigo()
            };

            tabela.inserir(Registro);
            MessageBox.Show("Registro cadastrado com sucesso!");
            this.Dispose();
        }

        private void editar()
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            Registro.nome = txtDescricao.Text.ToUpper();
            Registro.preco = Double.Parse(txtPreco.Text, NumberStyles.Currency);
            Registro.idtipo = Convert.ToInt16(cbCategoria.SelectedValue);
                    
            tabela.editar(Registro);
            MessageBox.Show("Registro editado com sucesso!");
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Registro = null;
            this.Dispose();
        }

        private void FormFichaProduto_Load(object sender, EventArgs e)
        {
            controle.TipoDB tabelaTipo = new controle.TipoDB();
            cbCategoria.DataSource = tabelaTipo.listar();
            cbCategoria.DisplayMember = "descricao";
            cbCategoria.ValueMember = "idtipo";

            if (Registro != null) {
                txtDescricao.Text = Registro.nome;
                txtPreco.Text = String.Format("{0,8:C2}", Registro.preco);
                cbCategoria.SelectedValue = Registro.idtipo;
            }
        }

        private void lnkNovoTipo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormFichaTipo fichaTipo = new FormFichaTipo();
            fichaTipo.Registro = null;
            fichaTipo.ShowDialog();

            if (fichaTipo.Registro != null)
            {
                controle.TipoDB tabelaTipo = new controle.TipoDB();
                cbCategoria.DataSource = tabelaTipo.listar();
                cbCategoria.SelectedValue = fichaTipo.Registro.idtipo;
            }
        }

        private void lnkEditarTipo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormFichaTipo fichaTipo = new FormFichaTipo();
            fichaTipo.Registro = (modelo.tipo)cbCategoria.SelectedItem;
            fichaTipo.ShowDialog();

            if (fichaTipo.Registro != null)
            {
                controle.TipoDB tabelaTipo = new controle.TipoDB();
                cbCategoria.DataSource = tabelaTipo.listar();
                cbCategoria.SelectedValue = fichaTipo.Registro.idtipo;
            }
        }

        private void lnkExcluirTipo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult op;
            modelo.tipo Registro =  (modelo.tipo)cbCategoria.SelectedItem;
            op = MessageBox.Show("Excluir o Registro: " + Registro.descricao,
                "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {
                controle.TipoDB tabelaTipo = new controle.TipoDB();
                if (tabelaTipo.testarExclusao(Registro.idtipo))
                {
                    tabelaTipo.excluir(Registro.idtipo);
                    cbCategoria.DataSource = tabelaTipo.listar();
                    cbCategoria.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Não é possivel excluir Registro");
                }              
            }
        }
    }
}
