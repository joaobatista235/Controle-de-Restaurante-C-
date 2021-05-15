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
    public partial class FormMesas : Form
    {
        public FormMesas()
        {
            InitializeComponent();
        }

        private void FormMesas_Load(object sender, EventArgs e)
        {
            controle.MesaDB tabela = new controle.MesaDB();
            tabela.consultar(bs);
            lbIdMesa.DataBindings.Add(new Binding("Text", bs, "idmesa"));
            lbVagas.DataBindings.Add(new Binding("Text", bs, "vagas"));

            Binding bStatus = new Binding("Text", bs, "status");
            bStatus.Format += bStatus_Format;
            lbSituacao.DataBindings.Add(bStatus);
        }

        void bStatus_Format(object sender, ConvertEventArgs e)
        {
            try
            {
                string[] array_status = new string[]{

                    "0 - MESA ESTA LIVRE",
                    "1 - MESA ESTA OCUPADA",
                    "2 - MESA ESTA RESERVADA",
                    "3 - MESA ESTA INDISPONIVEL"
                };

                int index = Convert.ToInt16(e.Value);
                e.Value = array_status[index];
            }
            catch (Exception)
            {
                e.Value = "Status inválido";
            }
        }

        private void FormMesas_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrincipal pai = (FormPrincipal)this.MdiParent;
            pai.mesas = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormFichaMesa ficha = new FormFichaMesa();
            ficha.Registro = null;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                controle.MesaDB tabela = new controle.MesaDB();
                tabela.consultar(bs);
                bs.MoveLast();
                bs.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormFichaMesa ficha = new FormFichaMesa();
            ficha.Registro = (modelo.mesa) bs.Current;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                controle.MesaDB tabela = new controle.MesaDB();
                tabela.consultar(bs);
                bs.ResetBindings(false);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult op;

            modelo.mesa Registro = (modelo.mesa)bs.Current;

            op = MessageBox.Show("Deseja EXCLUIR mesa numero :" 
                + Registro.idmesa, "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {
                controle.MesaDB tabela = new controle.MesaDB();
                tabela.excluir(Registro.idmesa);
                bs.RemoveCurrent();
                bs.ResetBindings(false);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            string pasta = controle.Registro.ler("restaurante", "relatorio");

            if (!Directory.Exists(pasta))
            {
                MessageBox.Show("Caminho não encontrado!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            report.FormRelatorio relatorio = new report.FormRelatorio();
            relatorio.Arquivo = @pasta + @"\rdMesa.rdlc";
            if (!File.Exists(relatorio.Arquivo))
            {
                MessageBox.Show("Relatório não encontrado!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            controle.MesaDB tabela = new controle.MesaDB();
            relatorio.DS = tabela.relatorio();
            relatorio.Show();
        }
    }
}
