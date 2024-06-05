using System;
using System.Data;
using System.Windows.Forms;

namespace TourExplorer {
    public partial class DeleteTourForm : Form {
        public DeleteTourForm() {
            InitializeComponent();
            LoadTours();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void DeleteTourForm_FormClosed(object sender, FormClosedEventArgs e) {
            Close();
        }

        private void LoadTours() {
            DataTable toursTable = Session.CurrentSession.DatabaseOracle.GetAllTours();
            comboBoxTourName.ValueMember = "NUMER_KATALOGOWY_WYCIECZKI";
            comboBoxTourName.DataSource = toursTable;
            comboBoxTourName.SelectedIndex = -1;
        }
        private void comboBoxTourName_Format(object sender, ListControlConvertEventArgs e) {
            // formatowanie wyświetlenie elementów listy
            DataRowView dataRowView = (DataRowView)e.ListItem;
            int tourId = Convert.ToInt32(dataRowView["numer_katalogowy_wycieczki"]);
            string tourName = dataRowView["nazwa_wycieczki"].ToString();
            e.Value = $"{tourId}. {tourName}";
        }

        private void buttonDeleteTour_Click(object sender, EventArgs e) {
            if (comboBoxTourName.SelectedIndex == -1) {
                labelEmptyComboBox.Visible = true;
                return;
            }
            if (Session.CurrentSession.Role == Session.UserRole.Admin) {
                int tourId = Convert.ToInt32(comboBoxTourName.SelectedValue);
                Session.CurrentSession.DatabaseOracle.DeleteTour(tourId);
                MessageBox.Show("Usunąłeś wycieczkę z katalogu", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        } // buttonDeleteTour_Click ()
    } // class
} // namespace
