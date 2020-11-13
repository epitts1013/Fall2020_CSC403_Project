using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public static class Globals
    {
        public static int LevelNumber = 1;
        public static bool Level1Beat = false;
        public static bool LevelsGiven = false;
        public static bool PlayerIsAlive = true;
    }
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
            Application.Run(new FrmLevel());
            if (Form.ActiveForm == null && Globals.Level1Beat == true)
            {
                Globals.LevelNumber = 2;
                Application.Run(new Frm2Level());
            }

            if (Form.ActiveForm == null && Globals.LevelNumber == 3)
            {
                Application.Run(new FrmFinal());
            }
                //if (Globals.PlayerIsAlive == false)
            //{
                
           // }

        }
    }
}

