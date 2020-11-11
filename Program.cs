using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//111995 - Romero Luna Carmela.
//111942 - Ismael Zamuz. 
//111947 - Sebastian Leyria.
//111989 - Correa Causa Pablo.
namespace FormProgramacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCinema());
        }
    }
}
