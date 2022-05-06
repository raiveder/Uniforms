using System;
using System.Windows.Forms;

namespace Uniforms
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Other.firstRun();
            Application.Run(new Avtor());
        }
    }
}
