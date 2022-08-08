//using PDV.pdv.Views.empresa;
using System;
using System.Windows.Forms;

namespace PDV
{

    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /*
         * 
         */ 

        [STAThread]
        static void Main()
        {
            /// Cl_Dados.Cl_DadosInicio();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInicioViews());

        }
    }
}
