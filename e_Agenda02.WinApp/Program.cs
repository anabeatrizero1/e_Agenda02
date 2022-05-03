using e_Agenda02.Infra.Arquivo.ModiloTarefa;
using e_Agenda02.Infra.Arquivo.ModuloCompromisso;
using e_Agenda02.Infra.Arquivo.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda02.WinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
       
        [STAThread]
        static void Main()
        {
            

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListagemTarefasForm()); 
        }
    }
}
