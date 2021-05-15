using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteDBTA.visao
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            barra.Maximum = 100;
            barra.Minimum = 1;
            this.Cursor = Cursors.AppStarting;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barra.Increment(1);

            lbAcao.Text = "Concluido " + barra.Value.ToString().PadLeft(2, '0') + "%";
            if (barra.Value == 5)
            {
               TestaMYSQL();
            }

            if (barra.Value == 100)
            {
                timer1.Stop();
                this.Cursor = Cursors.Default;
            }
        }

        private void TestaMYSQL()
        {
            System.Net.Sockets.TcpClient cliente = new System.Net.Sockets.TcpClient();
            string IP = "localhost";
            try
            {
                cliente.Connect(IP, 3306);
            }
            catch (Exception)
            {
                MessageBox.Show("MYSQL OFF-LINE", "ALERTA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }
    }
}
