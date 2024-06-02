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
    public partial class TripsCatalogEditorForm : Form {
        private Session _session;
        private DatabaseOracle _databaseOracle;
        public TripsCatalogEditorForm() {
            InitializeComponent();
            _databaseOracle = new DatabaseOracle();
            _session = new Session(_databaseOracle);
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
    }
}
