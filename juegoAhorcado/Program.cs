using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juegoAhorcado
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form1 form1 = new Form1();
            //Form_Time form_Time= new Form_Time();
            
            //form1.FormClosed += Forms_Closed;
            //form_Time.FormClosed += Forms_Closed;
            //form1.Show();

            

            //Application.Run();
            Application.Run(new Form1());


        }

        //private static void Forms_Closed(object sender, FormClosedEventArgs e)
        //{
        //    ((Form)sender).FormClosed -= Forms_Closed;

        //    if (Application.OpenForms.Count == 0)
        //    {
        //        Application.ExitThread();
        //    }
        //    else
        //    {
        //        Application.OpenForms[0].FormClosed += Forms_Closed;
        //    }
        //}
    }
}
