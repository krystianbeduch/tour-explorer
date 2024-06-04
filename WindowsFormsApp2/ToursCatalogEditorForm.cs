using System;
using System.Drawing;
using System.Windows.Forms;

namespace TourExplorer {
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

        private void buttonExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonAddTourToCatalog_Click(object sender, EventArgs e) {
            AddNewTourForm addNewTourForm = new AddNewTourForm();        
            if (addNewTourForm.ShowDialog() == DialogResult.OK) {

            }
        }

        private void ToursCatalogEditorForm_FormClosed(object sender, FormClosedEventArgs e) {
            Close();
        }

        private void buttonDeleteTourFromCatalog_Click(object sender, EventArgs e) {
            DeleteTourForm deleteTourForm = new DeleteTourForm();
            if (deleteTourForm.ShowDialog() == DialogResult.OK) {

            }
        }
    } // class
} // namespace