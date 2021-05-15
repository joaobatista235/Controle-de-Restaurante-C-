using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteDBTA.report
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        internal string Arquivo { get; set; }
        internal DataSet DS { get; set; }


        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            try
            {
                report.LocalReport.DataSources.Clear();
                ReportDataSource source = null;
                source = new ReportDataSource(DS.DataSetName, DS.Tables[0]);
                report.LocalReport.DataSources.Add(source);
                report.LocalReport.ReportPath = @Arquivo;
                report.DocumentMapCollapsed = false;
                report.ProcessingMode = ProcessingMode.Local;
                this.report.RefreshReport();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao abrir o relatório:" + erro.Message,
                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
