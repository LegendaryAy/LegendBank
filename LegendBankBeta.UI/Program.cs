using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegendBankBeta.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Instatiating the globag config
            GlobalConfig.AddInstance();
            Application.Run(new Login(GlobalConfig.IAuthInstance, GlobalConfig.IUserInstance, GlobalConfig.IAccountInstance, GlobalConfig.context));
            
            //Removing the instance
            GlobalConfig.RemoveInstance();
        }
    }
}
