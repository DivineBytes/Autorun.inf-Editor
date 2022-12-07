using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Autorun.inf_Editor.Forms;

namespace Autorun.inf_Editor
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
            Application.Run(new Main());
        }
    }
}
