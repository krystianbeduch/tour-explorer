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
    public partial class EditUsersToursForm : Form {
        private DataTable _usersToursTable;
        public EditUsersToursForm() {
            InitializeComponent();
            toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession);  // pasek statusu (user)
            LoadUsersTour();
        }

        private void toolStripButtonDataBaseCheck_Click(object sender, EventArgs e) {
            // pasek statusu (baza)
            if (Session.CurrentSession.DatabaseOracle.CheckConnection()) {
                toolStripStatusLabelDataBase.Text = "Połączono z bazą danych Oracle";
                toolStripStatusLabelDataBase.ForeColor = Color.ForestGreen;
            }
            else {
                toolStripStatusLabelDataBase.Text = "Błąd podczas łączenia z bazą danych Oracle";
                toolStripStatusLabelDataBase.ForeColor = Color.Red;
            }
        }

        private void LoadUsersTour() {
            //////////////////////////////////////////////////////////////////////////////
            // załaduj wycieczki do tabeli Grid
            //_usersToursTable = Session.CurrentSession.DatabaseOracle.GetAllToursForEditor();
            dataGridViewTours.DataSource = _usersToursTable;
            dataGridViewTours.Columns["ID_KATALOGOWE_WYCIECZKI"].ReadOnly = true; // id
        }
    } // class
} // namespace
