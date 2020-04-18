using Frequenz.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frequenz
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

            //Get the directory for the config file.
            string config = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\config.txt"; 

            //Read the first file
            string configValue = File.ReadLines(config).First(); 

            //Parse the boolean part from the first string
            string value = configValue.Substring(configValue.LastIndexOf('=') + 2).Trim(new Char[] { ';' }); 

            //Check if config file exists
            //If it doesn't open Login Form
            if (!File.Exists(config))
            {
                File.Create(config);
                Application.Run(new Login());
            }
            else
            {
                //If the config file exists we can check if the user has:
                // - Ever logged in
                // - Decided to not stay logged in
                if (string.IsNullOrEmpty(configValue) || bool.Parse(value) == false)
                    Application.Run(new Login());
                else
                    Application.Run(new Frequenz()); //If all checks out log user in.
            }
        }
    }
}
