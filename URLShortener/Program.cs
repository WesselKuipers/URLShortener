using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using URLShortener.Service;

namespace URLShortener
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmUrlShortener());
        }

            /*
        static void Main()
        {
            for (int i = 0; i < 400; i++)
            {
                Console.WriteLine(UrlService.GenerateRandomName());
            }
        }*/
    }
}
