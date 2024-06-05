using System;
using System.Drawing;
using System.Windows.Forms;

namespace TourExplorer {
    public partial class UserToursEditorForm : Form {
        public UserToursEditorForm() {
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

        private void buttonEditUserTours_Click(object sender, EventArgs e) {

        }

        private void buttonAddTourForUser_Click(object sender, EventArgs e) {
            AddTourForUser addTourForUser = new AddTourForUser();
            addTourForUser.ShowDialog();
        }
        private void buttonDeleteTourFromUser_Click(object sender, EventArgs e) {

        }

   
        private void buttonExit_Click(object sender, EventArgs e) {
            Close();
        }
    } // class
} // namespace
