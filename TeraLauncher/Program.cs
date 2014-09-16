using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeraLauncher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static LoginForm Form;
        public static FormThread msg;

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                if (args[0] == "AeraGaming:MarHazK")
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Form = new LoginForm();
                    msg = new FormThread();
                    Application.Run(Form);
                }
                else
                {
                    MessageBox.Show("Please run TeraLauncher.exe first");
                    Environment.Exit(0);
                }
            }
            catch
            {
                bool marhazk = false;
                if (marhazk)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Form = new LoginForm();
                    msg = new FormThread();
                    Application.Run(Form);
                }
                else
                {
                    MessageBox.Show("Please run TeraLauncher.exe first");
                    Environment.Exit(0);
                }
            }
        }
    }
}
