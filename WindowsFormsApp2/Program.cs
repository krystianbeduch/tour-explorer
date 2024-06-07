using System;
using System.IO;
using System.Windows.Forms;

namespace TourExplorer {
    internal static class Program {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main() {
            //try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new WelcomeForm());
            //}
            //catch (Exception ex) {
                //LogError(ex);
                //MessageBox.Show("Wystąpił błąd. Szczegóły zostały zapisane w pliku error.log.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        static void LogError(Exception ex) {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");
            using (StreamWriter writer = new StreamWriter(logFilePath, true)) {
                writer.WriteLine($"{DateTime.Now}: {ex.Message}");
                writer.WriteLine(ex.StackTrace);
                writer.WriteLine();
            }
        }
    }
}
