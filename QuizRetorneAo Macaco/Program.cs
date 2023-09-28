using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizRetorneAo_Macaco
{

    //  NICOLLAS SOUZA
    //  SISTEMAS DE INFORMAÇÃO - NOITE
    //  MADRUGADA - 26/05/2023
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Questionario());
        }
    }
}
