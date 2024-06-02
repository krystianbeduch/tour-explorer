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
    public partial class AddNewTourForm : Form {
        private Session _session;
        private DatabaseOracle _databaseOracle;
        public string TourName { get; private set; }
        public int Price { get; private set; }

        public AddNewTourForm(Session session) {
            InitializeComponent();
            _session = session;
            _databaseOracle = new DatabaseOracle();
        }

        private void buttonAddTour_Click(object sender, EventArgs e) {
            TourName = textBoxTourName.Text;
            string PriceStr = textBoxPrice.Text;
            if (string.IsNullOrWhiteSpace(TourName) || string.IsNullOrWhiteSpace(PriceStr)) {
                labelEmptyTextBox.Visible = true;
                return;
            }
            if (!int.TryParse(PriceStr, out int Price)) {
                MessageBox.Show("Prowadź prawidłową cenę całkowito liczbową", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_session.Role == Session.UserRole.Admin) {
                _databaseOracle.AddNewTour(TourName, Price);
                DialogResult = DialogResult.OK;
                MessageBox.Show("Dodałeś nową wycieczkę do katalogu", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
