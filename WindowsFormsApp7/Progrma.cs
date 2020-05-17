using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    static class Programa
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*
            Triangle triangle = new Triangle();
            triangle.Number = 13;
            triangle.Number2 = 66;
            triangle.Number3 = 55;
            triangle.OperationCode =1 ;
            triangle.Triangleg();
            Console.WriteLine(triangle.Result);
            */
        }
    }
}