using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace logicPuzzles
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NavigationViewController navigationController = NavigationViewController.getInstance();
            Application.Run(new RootViewController(navigationController));
        }
    }
}
