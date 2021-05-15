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
    public partial class FormFichaItemProdutos : Form
    {
        public FormFichaItemProdutos()
        {
            InitializeComponent();
        }


        internal modelo.cardapio Registro { get; set; }


        private void FormFichaItemProdutos_Load(object sender, EventArgs e)
        {
            lbIdCardapio.Text = Registro.idcardapio.ToString().PadLeft(12, '0');
            lbDescricao.Text = Registro.descricao;
            controle.Item_cardapioDB tabela = new controle.Item_cardapioDB();
            bs.DataSource = tabela.listar(Registro.idcardapio);

            Binding bIdItem = new Binding("Text", bs, "item_cardapio1");
            bIdItem.Format += bIdItem_Format;
            lbItemCardapio.DataBindings.Add(bIdItem);

            Binding bIdProduto = new Binding("Text", bs, "idproduto");
            bIdProduto.Format += bIdProduto_Format;
            lbIdProduto.DataBindings.Add(bIdProduto);

            lbNomeProduto.DataBindings.Add(new Binding("Text", bs, "produto.nome"));
        }

        void bIdProduto_Format(object sender, ConvertEventArgs e)
        {
            try
            {
                string cod = e.Value.ToString();
                e.Value = cod.PadLeft(12, '0');
            }
            catch (Exception)
            {

                e.Value = "INVALIDO";
            }
        }

        void bIdItem_Format(object sender, ConvertEventArgs e)
        {
            try
            {
                string cod = e.Value.ToString();
                e.Value = cod.PadLeft(12, '0');
            }
            catch (Exception)
            {

                e.Value = "INVALIDO";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pesquisa.FormPesquisarProduto pesquisa = new pesquisa.FormPesquisarProduto();
            pesquisa.ShowDialog();

            if (pesquisa.Codigo != 0) {

                modelo.item_cardapio item = new modelo.item_cardapio();
                controle.Item_cardapioDB tabela = new controle.Item_cardapioDB();

                item = new modelo.item_cardapio
                {
                    item_cardapio1 = tabela.ProximoCodigo(),
                    idproduto = pesquisa.Codigo,
                    idcardapio = Registro.idcardapio
                };

                tabela.inserir(item);
                bs.DataSource = tabela.listar(Registro.idcardapio);
                bs.ResetBindings(false);
                bs.MoveLast();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pesquisa.FormPesquisarProduto pesquisa = new pesquisa.FormPesquisarProduto();
            pesquisa.ShowDialog();

            if (pesquisa.Codigo != 0)
            {

                modelo.item_cardapio item = (modelo.item_cardapio)bs.Current;
                controle.Item_cardapioDB tabela = new controle.Item_cardapioDB();

                item.idproduto = pesquisa.Codigo;
                item.idcardapio = Registro.idcardapio;
                tabela.editar(item);

                bs.DataSource = tabela.listar(Registro.idcardapio);
                bs.ResetBindings(false);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            modelo.item_cardapio item = (modelo.item_cardapio)bs.Current;
            controle.Item_cardapioDB tabela = new controle.Item_cardapioDB();
            tabela.excluir(item.item_cardapio1);
            bs.RemoveCurrent();
            bs.ResetBindings(false);
            bs.MoveFirst();
        }
    }
}
