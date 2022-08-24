using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the database connections. (false, true) to make it use the text file database. Chose to not incorporate SQL database.
            TrackerLibrary.GlobalConfig.InitializeConnections(false, true);
            Application.Run(new TournamentDashboardForm());
        }
    }
}
