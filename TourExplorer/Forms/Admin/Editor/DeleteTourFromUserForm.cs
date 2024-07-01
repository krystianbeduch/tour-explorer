using System;
using System.Data;
using System.Windows.Forms;

namespace TourExplorer {
    /// <summary>
    /// Formularz do usuwania wycieczek konkretnego klienta
    /// </summary>
    public partial class DeleteTourFromUserForm : Form {
        private bool loadingClients = false;
        public DeleteTourFromUserForm() {
            InitializeComponent();
            LoadClients();
        }

        private void LoadClients() {
            // załadowanie klientów do listy
            loadingClients = true;
            DataTable toursTable = Session.CurrentSession.DatabaseOracle.GetAllClients();
            comboBoxClient.ValueMember = "ID_KLIENTA";
            comboBoxClient.DataSource = toursTable;
            comboBoxClient.SelectedIndex = -1;
            loadingClients = false;
        }

        private void comboBoxClient_Format(object sender, ListControlConvertEventArgs e) {
            // formatowanie wyświetlenie elementów listy
            DataRowView dataRowView = (DataRowView)e.ListItem;
            int clientId = Convert.ToInt32(dataRowView["ID_KLIENTA"]);
            string firstName = dataRowView["IMIE"].ToString();
            string lastName = dataRowView["NAZWISKO"].ToString();
            e.Value = $"{clientId}. {firstName} {lastName}";
        }
        private void LoadToursForUser(int clientId) {
            // załadowanie wycieczek do listy
            DataTable toursTable = Session.CurrentSession.DatabaseOracle.GetClientsTrips(clientId);
            comboBoxTourName.ValueMember = "NUMER_REZERWACJI";
            comboBoxTourName.DataSource = toursTable;
            comboBoxTourName.SelectedIndex = -1;
        }

        private void comboBoxTourName_Format(object sender, ListControlConvertEventArgs e) {
            // formatowanie wyświetlenie elementów listy
            DataRowView dataRowView = (DataRowView)e.ListItem;
            int reservationId = Convert.ToInt32(dataRowView["NUMER_REZERWACJI"]);
            string tourName = dataRowView["NAZWA_WYCIECZKI"].ToString();
            e.Value = $"#{reservationId}. {tourName}";
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e) {
            // obsługa zdarzenia zmiany klienta na liście - przeładowanie listy wycieczek
            if (!loadingClients && comboBoxClient.SelectedIndex != -1) {
                int clientId = Convert.ToInt32(comboBoxClient.SelectedValue);
                LoadToursForUser(clientId);
            }
        }

        private void buttonDeleteUserTour_Click(object sender, EventArgs e) {
            // obsługa przycisku "Usuń" - usuwanie wycieczki klienta
            if (comboBoxTourName.SelectedIndex == -1 || comboBoxClient.SelectedIndex == -1) {
                labelEmptyComboBox.Visible = true;
                return;
            }
            if (Session.CurrentSession.Role == Session.UserRole.Admin) {
                int reservationId = Convert.ToInt32(comboBoxTourName.SelectedValue);
                Session.CurrentSession.DatabaseOracle.WriteOutUserFromTour(reservationId);
                MessageBox.Show("Usunąłeś wycieczkę klienta", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            // obsługa przycisku "Anuluj" - wyjście z okna
            DialogResult = DialogResult.Cancel;
            Close();
        }
    } // class
} // namespace