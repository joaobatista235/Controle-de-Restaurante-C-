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
    public partial class FormFichaMesa : Form
    {
        public FormFichaMesa()
        {
            InitializeComponent();
        }

        internal modelo.mesa Registro { get; set; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Registro = null;
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Registro == null) novo();
            else editar();
            this.Dispose();

        }

        private void novo()
        {
            controle.MesaDB tabela = new controle.MesaDB();

            Registro = new modelo.mesa
            {
                idmesa = tabela.ProximoCodigo(),               
                status = cbStatus.SelectedIndex,
                vagas = Int16.Parse(txtCadeiras.Text)
            };

            tabela.inserir(Registro);
            MessageBox.Show("Registro cadastrado!");
        }

        private void editar()
        {
            controle.MesaDB tabela = new controle.MesaDB();
            Registro.status = cbStatus.SelectedIndex;
            Registro.vagas = Int16.Parse(txtCadeiras.Text);
            tabela.editar(Registro);
        }

        private void FormFichaMesa_Load(object sender, EventArgs e)
        {
            if (Registro != null)
            {
                txtCadeiras.Text = Registro.vagas.ToString();
                cbStatus.SelectedIndex = Convert.ToInt16(Registro.status);
            }
        }
    }
}
