using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteDBTA.visao
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrincipal pai = (FormPrincipal) this.MdiParent;
            pai.produto = null;
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            tabela.consultar(bs);

            Binding bIdProduto = new Binding("Text", bs, "idproduto");
            bIdProduto.Format += bIdProduto_Format;
            lbIdProduto.DataBindings.Add(bIdProduto);

            lbNomeProduto.DataBindings.Add(new Binding("Text", bs, "nome"));

            Binding bPreco = new Binding("Text", bs, "preco");
            bPreco.Format += bPreco_Format;
            lbPrecoProduto.DataBindings.Add(bPreco);

            lbTipoProduto.DataBindings.Add(new Binding("Text", bs, "tipo.descricao"));
        }

        void bIdProduto_Format(object sender, ConvertEventArgs e)
        {
            try
            {
                int Cod = Convert.ToInt32(e.Value);
                e.Value = Cod.ToString().PadLeft(12, '0');
            }
            catch (Exception)
            {

                e.Value = "000000000000";
            }
        }

        void bPreco_Format(object sender, ConvertEventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(e.Value);
                e.Value = valor.ToString("C2");
            }
            catch (Exception)
            {
                e.Value = "R$ 00,00";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormFichaProduto ficha = new FormFichaProduto();
            ficha.Registro = null;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                controle.ProdutoDB tabela = new controle.ProdutoDB();
                tabela.consultar(bs);
                bs.MoveLast();
                bs.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormFichaProduto ficha = new FormFichaProduto();
            ficha.Registro = (modelo.produto) bs.Current;
            ficha.ShowDialog();

            if (ficha.Registro != null)
            {
                controle.ProdutoDB tabela = new controle.ProdutoDB();
                tabela.consultar(bs);
                bs.ResetBindings(false);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult op;

            modelo.produto Registro = (modelo.produto)bs.Current;

            op = MessageBox.Show("Deseja EXCLUIR :" + Registro.nome, "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {
                controle.ProdutoDB tabela = new controle.ProdutoDB();
                tabela.excluir(Registro.idproduto);
                bs.RemoveCurrent();
                bs.ResetBindings(false);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisa.FormPesquisarProduto pesquisa = new pesquisa.FormPesquisarProduto();
            pesquisa.ShowDialog();
            if (pesquisa.Codigo != 0)
            {
                var lista = bs.List.OfType<modelo.produto>().ToList();
                var consulta = lista.Find(i=> i.idproduto == pesquisa.Codigo);
                bs.Position = bs.IndexOf(consulta);
                btnEdit_Click(sender, e);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            string pasta = controle.Registro.ler("restaurante", "relatorio");

            if (!Directory.Exists(pasta))
            {
                MessageBox.Show("Caminho não encontrado!","ERRO",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            report.FormRelatorio relatorio = new report.FormRelatorio();

            relatorio.Arquivo = @pasta + @"\rdProduto.rdlc";
            if (!File.Exists(relatorio.Arquivo))
            {
                MessageBox.Show("Relatório não encontrado!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            relatorio.DS = tabela.relatorio();
            relatorio.Show();
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            string pasta = controle.Registro.ler("restaurante", "relatorio");

            if (!Directory.Exists(pasta))
            {
                MessageBox.Show("Caminho não encontrado!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            report.FormRelatorio relatorio = new report.FormRelatorio();
            relatorio.Arquivo = @pasta + @"\rdGraficoProduto.rdlc";

            if (!File.Exists(relatorio.Arquivo))
            {
                MessageBox.Show("Relatório não encontrado!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controle.ProdutoDB tabela = new controle.ProdutoDB();
            relatorio.DS = tabela.grafico();
            relatorio.Show();
        }
    }
}
