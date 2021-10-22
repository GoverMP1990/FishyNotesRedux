using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishyNotesRedux.Interfaces;

namespace FishyNotesRedux
{
    static class Program
    {
        // Variables

        private Dictionary<int, INoteData> _notes;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FishyNotes());
        }

        public void init()
        {

        }
    }
}
