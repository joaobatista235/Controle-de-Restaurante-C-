﻿using System;
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
    public partial class FormFichaTipo : Form
    {
        public FormFichaTipo()
        {
            InitializeComponent();
        }

        internal modelo.tipo Registro { get; set; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Registro = null;
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validacao() == false) return;

            if (Registro == null) novo();
            else editar();
        }

        private bool validacao()
        {
            if (txtDescricao.Text.Equals("")) {
                errorProvider1.SetIconPadding(txtDescricao, -20);
                errorProvider1.SetError(txtDescricao,"Descricao vazia");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtDescricao, string.Empty);
            }

            return true;
        }

        private void novo()
        {
            try
            {
                controle.TipoDB tabela = new controle.TipoDB();
                Registro = new modelo.tipo
                {
                    idtipo = tabela.ProximoCodigo(),
                    descricao = txtDescricao.Text
                };

                tabela.inserir(Registro);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar:" + erro.Message);
            }

            this.Dispose();
        }

        private void editar()
        {
            try
            {
                controle.TipoDB tabela = new controle.TipoDB();
                Registro.descricao = txtDescricao.Text;
                tabela.editar(Registro);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao editar:" + erro.Message);
            }

            this.Dispose();
        }

        private void FormFichaTipo_Load(object sender, EventArgs e)
        {
            if (Registro != null)
            {
                txtDescricao.Text = Registro.descricao;
            }
            
        }
    }
}
