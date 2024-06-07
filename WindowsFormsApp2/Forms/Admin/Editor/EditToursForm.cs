using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TourExplorer {
    /// <summary>
    /// Formularz umożliwiający edycję danych istniejących wycieczek
    /// </summary>
    public partial class EditToursForm : Form {
        private DataTable _toursTable;
        public EditToursForm() {
            InitializeComponent();
            toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession);  // pasek statusu (user)
            LoadTours();
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

        private void LoadTours() {
            // załaduj wycieczki do tabeli Grid
            _toursTable = Session.CurrentSession.DatabaseOracle.GetAllToursForEditor();
            dataGridViewTours.DataSource = _toursTable;
            dataGridViewTours.Columns["ID_KATALOGOWE_WYCIECZKI"].ReadOnly = true; // id
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e) {
            // obsługa przycisku "Zapisz zmiany" - aktualizuj dane wycieczek w bazie
            foreach (DataRow row in _toursTable.Rows) {
                if (row.RowState == DataRowState.Modified) {
                    int tourId = Convert.ToInt32(row["ID_KATALOGOWE_WYCIECZKI"]);
                    string tourName = row["NAZWA_WYCIECZKI"].ToString();
                    int price = Convert.ToInt32(row["CENA_WYCIECZKI"]);
                    Session.CurrentSession.DatabaseOracle.UpdateTour(tourId, tourName, price);
                }
            }
            MessageBox.Show("Zmiany zostały zapisane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTours(); // odśwież dane po zapisaniu
        } // buttonSaveChanges_Click()

        private void buttonExit_Click(object sender, EventArgs e) {
            // obsługa przycisku "Wyjdź z edytora" - wyjście z okna
            Close();
        } // buttonExit_Click()
    } // class
} // namespace
