using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kpo4310.mvv.Lib;
using Kpo4310.mvv.main.source;
using System.IO;

namespace Kpo4310.mvv.main
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        
        [STAThread]
        static void Main()
        {
            Kpo4310.mvv.Lib.AppGlobalSettings.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
             
        }
    }
}
