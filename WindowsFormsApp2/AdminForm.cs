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
    public partial class AdminForm : Form {
        private Session _session;
        private DatabaseOracle _databaseOracle;
        private HelloForm _helloForm;

        public AdminForm() {
            InitializeComponent();
        }
        public AdminForm(Session session, HelloForm helloForm) {
            InitializeComponent();
            _session = session;
            toolStripLabelSessionInfo.Text = Convert.ToString(_session);
            _databaseOracle = new DatabaseOracle();
            _helloForm = helloForm;
        }

        private void toolStripButtonDataBaseCheck_Click(object sender, EventArgs e) {
            if (_databaseOracle.CheckConnection()) {
                toolStripStatusLabelDataBase.Text = "Połączono z bazą danych Oracle";
                toolStripStatusLabelDataBase.ForeColor = Color.ForestGreen;
            }
            else {
                toolStripStatusLabelDataBase.Text = "Błąd podczas łączenia z bazą danych Oracle";
                toolStripStatusLabelDataBase.ForeColor = Color.Red;
            }
        }

        private void buttonLogoutUser_Click(object sender, EventArgs e) {
            Close();
            DialogResult = DialogResult.Retry;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e) {
            _helloForm.Show();
        }
    }
}
