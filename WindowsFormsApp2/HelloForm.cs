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
        //private Session _session;
        //private DatabaseOracle _databaseOracle;
        
        public HelloForm() {
            InitializeComponent();
            //_databaseOracle = new DatabaseOracle();
            //_session = new Session(_databaseOracle);
            //Session.CurrentSession.DatabaseOracle = new DatabaseOracle();
            //Session.CurrentSession = _session;

            Session.CurrentSession = new Session(new DatabaseOracle());
            
        }
        /*private void connectToDataBase() {
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
        }*/
        private void buttonDataBaseCheck_Click(object sender, EventArgs e) {
            // sprawdz polaczenie z baza
            //connectToDataBase();
            MessageBox.Show("Połączono z bazą danych Oracle!", "Połączono", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            toolStripStatusLabelDataBase.Text = "Połączono z bazą danych Oracle";
            toolStripStatusLabelDataBase.ForeColor = Color.ForestGreen;
        }

        private void buttonLoginAsGuest_Click(object sender, EventArgs e) {
            // zaloguj jako gosc
            Session.CurrentSession.LoginAsGuest();
            MessageBox.Show("Zalogowano jako gość \n" + Session.CurrentSession, "Zalogowano", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession);
            buttonContinue.Visible = true;
            buttonContinue.Enabled = true;
        }

        public void buttonLoginAsUser_Click(object sender, EventArgs e) {
            // logowanie uzytkownika
            bool isAdmin = false;
            LoginForm loginForm = new LoginForm(Session.CurrentSession, isAdmin);
            if (loginForm.ShowDialog() == DialogResult.OK) {
                toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession);
                AcceptButton = buttonContinue;
                buttonContinue.Visible = true;
                buttonContinue.Enabled = true;
                
            }
        }

        private void buttonLoginAsAdmin_Click(object sender, EventArgs e) {
            // logowanie administatora (przewodnika)
            LoginForm loginForm = new LoginForm(Session.CurrentSession, true);
            if (loginForm.ShowDialog() == DialogResult.OK) {
                toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession);
                AdminForm adminForm = new AdminForm(this);////////////////////////////////////////////////////
                //AdminForm adminForm = new AdminForm();
                Hide();

                if (adminForm.ShowDialog() == DialogResult.Retry) {
                    Session.CurrentSession = null;
                    toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession);
                    Session.CurrentSession = new Session(new DatabaseOracle());//////////////////////////
                    adminForm.Dispose();
                    Show();
                }
            }

        }

        private void buttonContinue_Click(object sender, EventArgs e) {
            if (Session.CurrentSession.Role == Session.UserRole.Guest) {
                ToursCatalogForm tripsCatalogForm = new ToursCatalogForm();
                Hide();
                tripsCatalogForm.ShowDialog();
                tripsCatalogForm.Dispose();
                Show();
            }
            else if(Session.CurrentSession.Role == Session.UserRole.RegisteredUser) {
                MainForm mainForm = new MainForm(this);
                //MainForm mainForm = new MainForm();//////////////////////////////////////////////
                Hide();

                if (mainForm.ShowDialog() == DialogResult.Retry) {
                    Session.CurrentSession = null;
                    toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession);
                    Session.CurrentSession = new Session(new DatabaseOracle());
                    mainForm.Dispose();
                    buttonContinue.Visible = false;
                    Show();
                }

            }

        } // buttonContinue_Click()

        private void buttonLoginHelp_Click(object sender, EventArgs e) {
            MessageBox.Show("Gość - możesz jedynie przeglądać katalog wycieczek \n\n" +
                "Klient - możesz przeglądać swoje wycieczki, przejrzeć katalog wycieczek i zapisać się na nową wycieczkę \n\n" +
                "Admin - jeśli jesteś naszym przewodnikiem możesz zarządzać katalogiem wycieczek oraz wycieczkami naszych klientów",
                "Pomoc", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        } // toolStripButtonDataBaseCheck_Click()
    } // class
} // namespace
