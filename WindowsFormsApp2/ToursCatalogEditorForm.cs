using System;
using System.Drawing;
using System.Windows.Forms;

namespace TourExplorer {
    /// <summary>
    /// Edytor katalogu - w tym oknie administrtor wybiera czy chce edytować, dodawać czy usuwać wycieczki
    /// </summary>
    public partial class ToursCatalogEditorForm : Form {
        public ToursCatalogEditorForm() {
            InitializeComponent();
            toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession); // pasek statusu (user)
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

        private void buttonEditTours_Click(object sender, EventArgs e) {
            // wybór 1. opcji - Edycja wycieczek z katalogu
            EditToursForm editToursForm = new EditToursForm();
            Hide();
            editToursForm.ShowDialog();
            Show();
        }

        private void buttonAddTourToCatalog_Click(object sender, EventArgs e) {
            // wybór 2. opcji - Dodawnie wycieczki do katalogu
            AddNewTourForm addNewTourForm = new AddNewTourForm();
            Hide();
            addNewTourForm.ShowDialog();
            Show();
        }

        private void buttonDeleteTourFromCatalog_Click(object sender, EventArgs e) {
            // wybór 3. opcji - Usuwanie wycieczki z katalogu
            DeleteTourForm deleteTourForm = new DeleteTourForm();
            Hide();
            deleteTourForm.ShowDialog();
            Show();
        }

        private void buttonExit_Click(object sender, EventArgs e) {
            // wybór 4. opcji - Wyjście z edytora wycieczek
            Close();
        }
    } // class
} // namespace