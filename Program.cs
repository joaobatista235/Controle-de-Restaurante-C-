using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteDBTA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splash();
            RegistroMySQL();
            visao.FormPrincipal principal = new visao.FormPrincipal();
            principal.Usuario = validacao();
            Application.Run(principal);
        }

        private static void RegistroMySQL()
        {
            string servidor = controle.Registro.ler("restaurante", "servidor");
            if (servidor == string.Empty)
            {
                Application.Run(new validacao.FormBancoDados());
            }
        }

        private static void splash()
        {
            ThreadStart start = new ThreadStart(BemVindo);
            Thread t = new Thread(start);
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
        }

        private static void BemVindo()
        {
            Application.Run(new visao.FormSplash());
        }

        private static string validacao()
        {
            validacao.FormLogin login = new validacao.FormLogin();
            Application.Run(login);
            return login.Usuario;
        }
    }
}
