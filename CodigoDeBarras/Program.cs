using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoDeBarras
{
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
            //Application.Run(new frmCustoPorSubGrupo());
            Application.Run(new frmPrincipal());
            //Application.Run(new frmEstoqueApuradoSimples());
            //Application.Run(new frmEstoqueApurado());
            //Application.Run(new frmImprimirEtiqueta());
            //Application.Run(new frmEstoqueSistema());
            //Application.Run(new frmEstoqueConferir());
            //Application.Run(new frmGerarEtiqueta());
            //Application.Run(new PopupImpressao());
        }
    }
}
