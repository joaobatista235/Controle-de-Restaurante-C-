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
    public partial class FormPrincipal : Form
    {
        // area dos formulários
        public FormProduto produto = null;
        public validacao.FormFichaUsuarios usuarios = null;
        public FormMesas mesas = null;
        public FormCardapio cardapios = null;

        public string Usuario { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void mnProduto_Click(object sender, EventArgs e)
        {
            if (produto == null)
            {
                produto = new FormProduto();
                produto.MdiParent = this;
                produto.Show();
                produto.Location = new Point(0, 0);
            }
        }

        private void mnUsuarios_Click(object sender, EventArgs e)
        {
            if (!Usuario.Equals("admin"))
            {
                MessageBox.Show("Acesso permitido apenas ao administrador!",
                    "ALERTA",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            if (usuarios == null)
            {
                usuarios = new validacao.FormFichaUsuarios();
                usuarios.MdiParent = this;
                usuarios.Show();
                usuarios.Location = new Point(0, 0);
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            string[] cores = controle.Registro.ler("restaurante", "cor").Split(',');

            Controls.OfType<MdiClient>().
                FirstOrDefault().BackColor = Color.FromArgb(
                Int16.Parse(cores[0]), 
                Int16.Parse(cores[1]),
                Int16.Parse(cores[2])
                );

            string caminho = Environment.CurrentDirectory + "\\fundo.png";

            if (File.Exists(caminho))
            {
                this.BackgroundImage = Image.FromFile(caminho);
            }

            lbConexao.Text += " " + DateTime.Now.ToShortDateString() + " as " +
                DateTime.Now.ToShortTimeString();
            lbConexao.Text += " no Host: " + Environment.MachineName + " - " +
                Environment.OSVersion;

            if (!Usuario.Equals(""))
            {
                lbUser.Text = "USUÁRIO: " + Usuario.ToUpper();
               
            }
        }

        private void mnConfRelatorio_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (Directory.Exists(folderBrowserDialog1.SelectedPath))
            {
                if(@File.Exists(folderBrowserDialog1.SelectedPath + @"\rdProduto.rdlc")){
                    controle.Registro.escrever("restaurante", "relatorio", 
                        folderBrowserDialog1.SelectedPath);
                    MessageBox.Show("Caminho Salvo no Registro do Windows", "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("a pasta não contém arquivos de relatório");
                }
            }
        }

        private void mnConfColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            controle.Registro.escrever("restaurante", "cor",
                colorDialog1.Color.R.ToString() + "," + 
                colorDialog1.Color.G.ToString() + "," +
                colorDialog1.Color.B.ToString() 
                );

            Controls.OfType<MdiClient>().
                FirstOrDefault().BackColor = colorDialog1.Color;
        }

        private void mnConfImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "imagens|*.png";
            openFileDialog1.ShowDialog();

            if (File.Exists(openFileDialog1.FileName))
            {
                string caminho = Environment.CurrentDirectory + "\\fundo.png";
                if (File.Exists(caminho))
                {
                    this.BackgroundImage = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Delete(caminho);
                }

                File.Copy(openFileDialog1.FileName,caminho);
                this.BackgroundImage = Image.FromFile(caminho);
            }

        }

        private void mnMesa_Click(object sender, EventArgs e)
        {
            if (mesas == null)
            {
                mesas = new FormMesas();
                mesas.MdiParent = this;
                mesas.Show();
                mesas.Location = new Point(0, 0);
            }
        }


        private void mnCardapio_Click(object sender, EventArgs e)
        {
            if (cardapios == null)
            {
                cardapios = new FormCardapio();
                cardapios.MdiParent = this;
                cardapios.Show();
                cardapios.Location = new Point(0, 0);
            }
        }

        private void mnSair_Click(object sender, EventArgs e)
        {
            DialogResult op;
            op = MessageBox.Show("Deseja Sair?", "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (op == DialogResult.Yes)
            {
                 Environment.Exit(0);
            }
           
        }
    }
}
