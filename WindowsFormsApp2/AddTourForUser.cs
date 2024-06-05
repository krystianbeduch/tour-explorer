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
    public partial class AddTourForUser : Form {
        public AddTourForUser() {
            InitializeComponent();
            LoadTours();
            LoadClients();
        }

        private void LoadTours() {
            // załadowanie danych do listy
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

        private void buttonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonAddTour_Click(object sender, EventArgs e) {
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
        }
    }
}
