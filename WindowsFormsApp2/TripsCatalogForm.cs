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
    public partial class TripsCatalogForm : Form {
        private Session _session;
        private DatabaseOracle _databaseOracle;
        public TripsCatalogForm(Session _session) {
            InitializeComponent();
        }

        private void TripsCatalogForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
