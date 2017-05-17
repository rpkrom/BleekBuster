using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//You have to add this namespace to access or call any forms 
//from the UI Folder. Otherwise, you will get an error about
//the form reference is not found.
using MeramecNetFlixProject.UI;

namespace MeramecNetFlixProject
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
            Application.Run(new UI.MainMenu());
        }
    }
}
