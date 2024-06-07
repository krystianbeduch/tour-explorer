using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TourExplorer {
    public partial class EditUsersToursForm : Form {
        private DataTable _usersToursTable;
        public EditUsersToursForm() {
            InitializeComponent();
            toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession); // pasek statusu (user)
            LoadUsersTour();
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

        private void LoadUsersTour() {
            // załaduj wycieczki klientów do tabeli Grid
            _usersToursTable = Session.CurrentSession.DatabaseOracle.GetAllUsersToursForEditor();
            dataGridViewTours.DataSource = _usersToursTable;
            dataGridViewTours.Columns["NUMER_REZERWACJI"].ReadOnly = true; // id
            dataGridViewTours.Columns["DATA_REZERWACJI"].ReadOnly = true;
            dataGridViewTours.Columns["KLIENT"].ReadOnly = true;
            dataGridViewTours.Columns["NAZWA_WYCIECZKI"].ReadOnly = true;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e) {
            // obsługa przycisku "Zapisz zmiany" - aktualizuj dane wycieczek klientów w bazie
            foreach (DataRow row in _usersToursTable.Rows) {
                if (row.RowState == DataRowState.Modified) {
                    int reservationId = Convert.ToInt32(row["NUMER_REZERWACJI"]);
                    string pickupLocation = row["MIEJSCE_ODBIORU"].ToString();
                    Session.CurrentSession.DatabaseOracle.UpdateUsersTours(reservationId, pickupLocation);
                }
            }
            MessageBox.Show("Zmiany zostały zapisane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsersTour(); // odśwież dane po zapisaniu
        }

        private void buttonExit_Click(object sender, EventArgs e) {
            // obsługa przycisku "Wyjdź z edytora" - wyjście z okna
            Close();
        } // buttonExit_Click()
    } // class
} // namespace
