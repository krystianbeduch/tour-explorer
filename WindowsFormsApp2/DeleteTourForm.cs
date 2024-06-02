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
    public partial class DeleteTourForm : Form {
        private Session _session;
        private DatabaseOracle _databaseOracle;
        public int TourId { get; private set; }
        public DeleteTourForm(Session session) {
            InitializeComponent();
            _session = session;
            _databaseOracle = new DatabaseOracle();
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
            DataTable toursTable = _databaseOracle.GetAllTours();
            comboBoxTourName.DisplayMember = "NAZWA_WYCIECZKI";
            comboBoxTourName.ValueMember = "NUMER_KATALOGOWY_WYCIECZKI";
            comboBoxTourName.DataSource = toursTable;

        }

        private void buttonDeleteTour_Click(object sender, EventArgs e) {
            if (comboBoxTourName.SelectedValue == null) {
                labelEmptyComboBox.Visible = true;
                return;
            }
            if (_session.Role == Session.UserRole.Admin) {
                TourId = Convert.ToInt32(comboBoxTourName.SelectedValue);
                _databaseOracle.DeleteTour(TourId);
                DialogResult = DialogResult.OK;
                MessageBox.Show("Usunąłeś wycieczkę z katalogu", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

        }
    }
}
