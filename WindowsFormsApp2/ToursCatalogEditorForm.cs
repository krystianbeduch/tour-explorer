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
    public partial class ToursCatalogEditorForm : Form {
        //private Session _session;
        //private DatabaseOracle _databaseOracle;
        public ToursCatalogEditorForm() {
            InitializeComponent();
            //_databaseOracle = new DatabaseOracle();
            //_session = session;
            toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession);
        }

        private void toolStripButtonDataBaseCheck_Click(object sender, EventArgs e) {
            if (Session.CurrentSession.DatabaseOracle.CheckConnection()) {
                toolStripStatusLabelDataBase.Text = "Połączono z bazą danych Oracle";
                toolStripStatusLabelDataBase.ForeColor = Color.ForestGreen;
            }
            else {
                toolStripStatusLabelDataBase.Text = "Błąd podczas łączenia z bazą danych Oracle";
                toolStripStatusLabelDataBase.ForeColor = Color.Red;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonAddTourToCatalog_Click(object sender, EventArgs e) {
            AddNewTourForm addNewTourForm = new AddNewTourForm();        
            if (addNewTourForm.ShowDialog() == DialogResult.OK) {

            }
        }

        private void ToursCatalogEditorForm_FormClosed(object sender, FormClosedEventArgs e) {
            Close();
        }

        private void buttonDeleteTourFromCatalog_Click(object sender, EventArgs e) {
            DeleteTourForm deleteTourForm = new DeleteTourForm();
            if (deleteTourForm.ShowDialog() == DialogResult.OK) {

            }
        }
    }
}
