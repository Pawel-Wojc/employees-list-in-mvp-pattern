using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //dopisane
            var view = new View.Form1();
            var model = new Models.mainModel();
            var presenter = new Presenters.mainPresenter(view, model);


            Application.Run(view);
        }
    }
}
