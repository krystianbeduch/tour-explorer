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
        public AdminForm(Session session) {
            InitializeComponent();
            _session = session;
        }
    }
}
