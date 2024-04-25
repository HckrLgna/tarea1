using OpenTK;
using Proyecto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_01
{
    class Program
    {
        [STAThread]
        static void Main(string[] args) 
        {
            // Inicia el hilo para el formulario principal
            
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
             

            // Inicia el hilo para la ventana de juego
             

            // Espera a que ambos hilos finalicen

            
             
        }
    }
}
