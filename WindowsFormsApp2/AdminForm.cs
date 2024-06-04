using System;
using System.Drawing;
using System.Windows.Forms;

namespace TourExplorer {
    public partial class AdminForm : Form {
        private HelloForm _helloForm;

        public AdminForm(HelloForm helloForm) {
            InitializeComponent();
            toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession);  // pasek statusu (user)
            _helloForm = helloForm;
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

        private void buttonLogoutUser_Click(object sender, EventArgs e) {
            Close();
            DialogResult = DialogResult.Retry;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e) {
            _helloForm.Show();
        }

        private void buttonEditTourCatalog_Click(object sender, EventArgs e) {
            ToursCatalogEditorForm tripsCatalogEditorForm = new ToursCatalogEditorForm();
            Hide();
            tripsCatalogEditorForm.ShowDialog();
            Show();
        }
    }
}
