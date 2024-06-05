using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourExplorer {
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
            _toursTable = Session.CurrentSession.DatabaseOracle.GetAllToursForEditor();
            dataGridViewTours.DataSource = _toursTable;
            dataGridViewTours.Columns["ID_KATALOGOWE_WYCIECZKI"].ReadOnly = true; // id
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e) {
            //try {
                foreach (DataRow row in _toursTable.Rows) {
                    if (row.RowState == DataRowState.Modified) {
                        int tourId = Convert.ToInt32(row["ID_KATALOGOWE_WYCIECZKI"]);
                        string tourName = row["NAZWA_WYCIECZKI"].ToString();
                        int price = Convert.ToInt32(row["CENA_WYCIECZKI"]);

                        Session.CurrentSession.DatabaseOracle.UpdateTour(tourId, tourName, price);
                    }
                }

                MessageBox.Show("Zmiany zostały zapisane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTours(); // Odśwież dane po zapisaniu
            //}
            //catch (Exception ex) {
            //    MessageBox.Show("Wystąpił błąd podczas zapisywania zmian: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
        } // buttonSaveChanges_Click()

        private void buttonExit_Click(object sender, EventArgs e) {
            Close();
        }
    } // class
} // namespace
