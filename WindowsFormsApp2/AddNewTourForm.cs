using System;
using System.Windows.Forms;

namespace TourExplorer {
    /// <summary>
    /// Formularz do dodawania nowej wycieczki do katalogu
    /// </summary>
    public partial class AddNewTourForm : Form {
        public AddNewTourForm() {
            InitializeComponent();
        }

        private void buttonAddTour_Click(object sender, EventArgs e) {
            // obsługa przycisku "Dodaj" - dodaj wycieczkę do katalogu
            string tourName = textBoxTourName.Text;
            string priceStr = textBoxPrice.Text;
            if (string.IsNullOrWhiteSpace(tourName) || string.IsNullOrWhiteSpace(priceStr)) {
                labelEmptyTextBox.Visible = true;
                return;
            }
            if (!int.TryParse(priceStr, out int price)) {
                MessageBox.Show("Prowadź prawidłową cenę całkowito liczbową", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Session.CurrentSession.Role == Session.UserRole.Admin) {
                Session.CurrentSession.DatabaseOracle.AddNewTour(tourName, price);
                DialogResult = DialogResult.OK;
                MessageBox.Show("Dodałeś nową wycieczkę do katalogu", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        } // buttonAddTour_Click

        private void buttonCancel_Click(object sender, EventArgs e) {
            // obsługa przycisku "Anuluj" - wyjście z okna
            DialogResult = DialogResult.Cancel;
            Close();
        }
    } // class
} // namespace
