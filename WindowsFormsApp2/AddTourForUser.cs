using System;
using System.Data;
using System.Windows.Forms;

namespace TourExplorer {
    /// <summary>
    /// Formularz do dodawania wycieczek dla konkretnego klienta
    /// Dodana wycieczka będzie dostępna z poziomu zalogowanego klienta w jego panelu
    /// </summary>
    public partial class AddTourForUser : Form {
        public AddTourForUser() {
            InitializeComponent();
            LoadTours();
            LoadClients();
        }

        private void LoadTours() {
            // załadowanie wycieczek do listy
            DataTable toursTable = Session.CurrentSession.DatabaseOracle.GetAllTours();
            comboBoxTourName.ValueMember = "NUMER_KATALOGOWY_WYCIECZKI";
            comboBoxTourName.DataSource = toursTable;
            comboBoxTourName.SelectedIndex = -1;
        }
        private void comboBoxTourName_Format(object sender, ListControlConvertEventArgs e) {
            // formatowanie wyświetlenie elementów listy
            DataRowView dataRowView = (DataRowView)e.ListItem;
            int tourId = Convert.ToInt32(dataRowView["NUMER_KATALOGOWY_WYCIECZKI"]);
            string tourName = dataRowView["NAZWA_WYCIECZKI"].ToString();
            e.Value = $"{tourId}. {tourName}";
        }

        private void LoadClients() {
            // załadowanie klientów do listy
            DataTable toursTable = Session.CurrentSession.DatabaseOracle.GetAllClients();
            comboBoxClient.ValueMember = "ID_KLIENTA";
            comboBoxClient.DataSource = toursTable;
            comboBoxClient.SelectedIndex = -1;
        }

        private void comboBoxClient_Format(object sender, ListControlConvertEventArgs e) {
            // formatowanie wyświetlenie elementów listy
            DataRowView dataRowView = (DataRowView)e.ListItem;
            int clientId = Convert.ToInt32(dataRowView["ID_KLIENTA"]);
            string firstName = dataRowView["IMIE"].ToString();
            string lastName = dataRowView["NAZWISKO"].ToString();
            e.Value = $"{clientId}. {firstName} {lastName}";
        }

        private void buttonAddTour_Click(object sender, EventArgs e) {
            // dodanie wycieczki dla klienta
            if (comboBoxTourName.SelectedIndex == -1 || comboBoxClient.SelectedIndex == -1) {
                labelEmptyComboBox.Visible = true;
                return;
            }
            if (Session.CurrentSession.Role == Session.UserRole.Admin) {
                int tourId = Convert.ToInt32(comboBoxTourName.SelectedValue);
                int clientId = Convert.ToInt32(comboBoxClient.SelectedValue);
                Session.CurrentSession.DatabaseOracle.SignUserToTour(clientId, tourId);
                MessageBox.Show("Dodałeś wycieczke dla użytkonika", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        } // buttonAddTour_Click()

        private void buttonCancel_Click(object sender, EventArgs e) {
            // wyjście z okna
            DialogResult = DialogResult.Cancel;
            Close();
        }
    } // class
} // namespace
