using System;
using System.Drawing;
using System.Windows.Forms;

namespace TourExplorer {
    /// <summary>
    /// Panel administracyjny -  w tym oknie administrator wybiera czy chce edytować katalog wycieczek czy wycieczkai dla poszczególnych klientów
    /// </summary>
    public partial class AdminForm : Form {
        //private WelcomeForm _welcomeForm; ///??????????????

        public AdminForm() {
            InitializeComponent();
            toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession);  // pasek statusu (user)
            //_welcomeForm = welcomeForm;
        }

        private void toolStripButtonDataBaseCheck_Click(object sender, EventArgs e) {
            // pasek statusu (baza)
            if (Session.CurrentSession.DatabaseOracle.CheckConnection()) {
                toolStripStatusLabelDataBase.Text = "Połączono z bazą danych Oracle";
                toolStripStatusLabelDataBase.ForeColor = Color.ForestGreen;
            }
            else {
                toolStripStatusLabelDataBase.Text = "Błąd podczas łączenia z bazą danych Oracle";
                toolStripStatusLabelDataBase.ForeColor = Color.Red;
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e) {
            // zamknięcie okna powoduje uruchomienie
            //_welcomeForm.Show();         ///////////////////////////////?
        }

        private void buttonEditTourCatalog_Click(object sender, EventArgs e) {
            // wybór 1. opcji - Edycja wycieczek klientów
            ToursCatalogEditorForm tripsCatalogEditorForm = new ToursCatalogEditorForm();
            Hide();
            tripsCatalogEditorForm.ShowDialog();
            Show();
        }

        private void buttonEditClientsTours_Click(object sender, EventArgs e) {
            // wybór 2. opcji - Edycja katalogu wycieczek
            UserToursEditorForm userToursEditorForm = new UserToursEditorForm();
            Hide();
            userToursEditorForm.ShowDialog();
            Show();
        }

        private void buttonLogoutAdmin_Click(object sender, EventArgs e) {
            // wybór 3. opcji - Wylogowanie z panelu administracyjnego
            DialogResult = DialogResult.Retry;
            Close();
        }
    } // class
} // namespace
