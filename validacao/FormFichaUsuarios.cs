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
    public partial class FormFichaUsuarios : Form
    {
        public FormFichaUsuarios()
        {
            InitializeComponent();
        }

        private void FormFichaUsuarios_Load(object sender, EventArgs e)
        {
            controle.UsuarioDB tabela = new controle.UsuarioDB();
            bs.DataSource = tabela.listar();
            dgvUsuarios.DataSource = bs;
           // dgvUsuarios.Columns["senha"].Visible = false;
            dgvUsuarios.Columns["email"].Width = 350;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCadastroLogin ficha = new FormCadastroLogin();
            ficha.Usuario = null;
            ficha.ShowDialog();
            if (ficha.Usuario != null)
            {
                controle.UsuarioDB tabela = new controle.UsuarioDB();
                bs.DataSource = tabela.listar();
                bs.ResetBindings(true);
                bs.MoveLast();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormCadastroLogin ficha = new FormCadastroLogin();
            ficha.Usuario = (modelo.usuarios) bs.Current;
            ficha.ShowDialog();
            if (ficha.Usuario != null)
            {
                controle.UsuarioDB tabela = new controle.UsuarioDB();
                bs.DataSource = tabela.listar();
                bs.ResetBindings(true);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (bs.Count == 0) return;

            modelo.usuarios Usuario = (modelo.usuarios)bs.Current;
            DialogResult op = MessageBox.Show("Excluir: " + Usuario.login,
                "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {
                 controle.UsuarioDB tabela = new controle.UsuarioDB();
                 tabela.excluir(Usuario.cod);
                 bs.RemoveCurrent();
                 bs.ResetBindings(true);
            }
        }
    }
}
