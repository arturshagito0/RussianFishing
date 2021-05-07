using System;
using System.Windows.Forms;

namespace pp3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Player player = new Player("art_shag");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new MainForm(player));
            Application.Run(new SaveForm());
            
        }

       
    }
}
