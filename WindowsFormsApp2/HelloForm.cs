using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace TourExplorer {
    public partial class HelloForm : Form {
        private Session _session;
        private DatabaseOracle _databaseOracle;
        
        public HelloForm() {
            InitializeComponent();
            _databaseOracle = new DatabaseOracle();
            _session = new Session(_databaseOracle);
        }
        private void connectToDataBase() {
            using (OracleConnection connection = _databaseOracle.GetConnection()) {
                try {
                    connection.Open();
                    
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT last_name FROM copy_emp WHERE employee_id = 200";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    label1.Text = dr.GetString(0);
                    connection.Dispose();

                    // Tutaj możesz wykonywać operacje na bazie danych
                }
                catch (Exception ex) {
                    MessageBox.Show("Błąd podczas łączenia z bazą danych Oracle: " + ex.Message, "Błąd", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    toolStripStatusLabelDataBase.Text = "Błąd podczas łączenia z bazą danych Oracle:" + ex.Message;
                    toolStripStatusLabelDataBase.ForeColor = Color.Red;
                }
                finally {
                    connection.Close();
                }
                
         }
        }
        private void buttonDataBaseCheck_Click(object sender, EventArgs e) {
            // sprawdz polaczenie z baza
            connectToDataBase();
            MessageBox.Show("Połączono z bazą danych Oracle!", "Połączono", MessageBoxButtons.OK, MessageBoxIcon.Information);
            toolStripStatusLabelDataBase.Text = "Połączono z bazą danych Oracle";
            toolStripStatusLabelDataBase.ForeColor = Color.ForestGreen;
        }

        private void buttonLoginAsGuest_Click(object sender, EventArgs e) {
            // zaloguj jako gosc
            _session.LoginAsGuest();
            MessageBox.Show("Zalogowano jako gość \n" + _session, "Zalogowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
            toolStripStatusLabelSessionInfo.Text = Convert.ToString(_session);
            buttonContinue.Visible = true;
            buttonContinue.Enabled = true;
        }

        public void buttonLoginAsUser_Click(object sender, EventArgs e) {
            // zaloguj uzytkownika
            LoginForm loginForm = new LoginForm(_session);
            if (loginForm.ShowDialog() == DialogResult.OK) {
                toolStripStatusLabelSessionInfo.Text = Convert.ToString(_session);
                AcceptButton = buttonContinue;
                buttonContinue.Visible = true;
                buttonContinue.Enabled = true;
                
            }
        }

        private void buttonLoginAsAdmin_Click(object sender, EventArgs e)
        {

        }

        private void buttonContinue_Click(object sender, EventArgs e) {
            if (_session.Role == Session.UserRole.Guest) {
                TripsCatalogForm tripsCatalogForm = new TripsCatalogForm(_session);
                tripsCatalogForm.ShowDialog();
                Hide();
            }
            else if(_session.Role == Session.UserRole.RegisteredUser) {
                MainForm mainForm = new MainForm(_session);
                mainForm.ShowDialog();
                Hide();    // ukryj okno powitalne
            }
            
        }
    }
}
