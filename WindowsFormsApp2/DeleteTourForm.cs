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
            comboBoxTourName.DisplayMember = "NAZWA_WYCIECZKI";
            comboBoxTourName.ValueMember = "NUMER_KATALOGOWY_WYCIECZKI";
            comboBoxTourName.DataSource = toursTable;
        }

        private void buttonDeleteTour_Click(object sender, EventArgs e) {
            if (comboBoxTourName.SelectedValue == null) {
                labelEmptyComboBox.Visible = true;
                return;
            }
            if (Session.CurrentSession.Role == Session.UserRole.Admin) {
                int tourId = Convert.ToInt32(comboBoxTourName.SelectedValue);
                Session.CurrentSession.DatabaseOracle.DeleteTour(tourId);
                DialogResult = DialogResult.OK;
                MessageBox.Show("Usunąłeś wycieczkę z katalogu", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        } // buttonDeleteTour_Click ()
    } // class
} // namespace
