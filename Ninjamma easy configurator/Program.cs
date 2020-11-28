using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninjamma_easy_configurator
{
    // DEFINITION DES MIXEURS ===========================
    static class Mixer
    {
        private static int[] inputs = new int[32];
        private static int[] outputs = new int[32];
        private static int[] frequency = new int[32];

        public static int[] Inputs { get => inputs; set => inputs = value; }
        public static int[] Outputs { get => outputs; set => outputs = value; }
        public static int[] Frequency { get => frequency; set => frequency = value; }
    }
    static class Program
    {
        

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        /// 




        [STAThread]






        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
           


        }
    }
}
