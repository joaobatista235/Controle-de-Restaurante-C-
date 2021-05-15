using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteDBTA.visao
{
    public partial class FormCardapio : Form
    {
        public FormCardapio()
        {
            InitializeComponent();
        }

        private void FormCardapio_Load(object sender, EventArgs e)
        {
            controle.CardapioDB tabela = new controle.CardapioDB();
            tabela.consultar(bs);
            Binding bIdCardapio = new Binding("Text", bs, "idcardapio");
            bIdCardapio.Format += bIdCardapio_Format;
            lbIdCardapio.DataBindings.Add(bIdCardapio);
            lbDescricao.DataBindings.Add (new Binding("Text",bs,"descricao"));
        }

        void bIdCardapio_Format(object sender, ConvertEventArgs e)
        {
            try
            {
                string cod = Convert.ToString(e.Value);
                e.Value = cod.PadLeft(8, '0');
            }
            catch (Exception)
            {

                e.Value = "INVALIDO";
            }
        }

        private void FormCardapio_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrincipal pai = (FormPrincipal)this.MdiParent;
            pai.cardapios = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormFichaCardapio ficha = new FormFichaCardapio();
            ficha.Registro = null;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                controle.CardapioDB tabela = new controle.CardapioDB();
                tabela.consultar(bs);
                bs.MoveLast();
                bs.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormFichaCardapio ficha = new FormFichaCardapio();
            ficha.Registro = (modelo.cardapio)bs.Current;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                controle.CardapioDB tabela = new controle.CardapioDB();
                tabela.consultar(bs);
                bs.ResetBindings(false);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult op;

            modelo.cardapio Registro = (modelo.cardapio)bs.Current;

            op = MessageBox.Show("Deseja EXCLUIR Cardapio numero :"
                + Registro.idcardapio, "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {
                controle.CardapioDB tabela = new controle.CardapioDB();
                tabela.excluir(Registro.idcardapio);
                bs.RemoveCurrent();
                bs.ResetBindings(false);
            }
        }

        private void btnCadastrarItems_Click(object sender, EventArgs e)
        {
            FormFichaItemProdutos ficha = new FormFichaItemProdutos();
            ficha.Registro = (modelo.cardapio)bs.Current;
            ficha.ShowDialog();
        }
    }
}
