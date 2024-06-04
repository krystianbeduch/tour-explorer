using System;
using System.Drawing;
using System.Windows.Forms;

namespace TourExplorer {
    public partial class HelloForm : Form {     
        public HelloForm() {
            InitializeComponent();
            Session.CurrentSession = new Session(new DatabaseOracle());
        }

        private void buttonDataBaseCheck_Click(object sender, EventArgs e) {
            if (Session.CurrentSession.DatabaseOracle.CheckConnection()) {
                toolStripStatusLabelDataBase.Text = "Połączono z bazą danych Oracle";
                toolStripStatusLabelDataBase.ForeColor = Color.ForestGreen;
            }
            else {
                toolStripStatusLabelDataBase.Text = "Błąd podczas łączenia z bazą danych Oracle";
                toolStripStatusLabelDataBase.ForeColor = Color.Red;
            }
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
        } // buttonLoginAsUser_Click()

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
        } // buttonLoginAsAdmin_Click()

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
