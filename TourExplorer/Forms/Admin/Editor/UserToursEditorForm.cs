﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace TourExplorer {
    public partial class UserToursEditorForm : Form {
        public UserToursEditorForm() {
            InitializeComponent();
            toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession); // pasek statusu (user)
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

        private void buttonEditUserTours_Click(object sender, EventArgs e) {
            // wybór 1. opcji - Edycja wycieczek klientów
            EditUsersToursForm editUsersToursForm = new EditUsersToursForm();
            Hide();
            editUsersToursForm.ShowDialog();
            Show();
        }

        private void buttonAddTourForUser_Click(object sender, EventArgs e) {
            // wybór 2. opcji - Dodawanie wycieczki dla klienta
            AddTourForUserForm addTourForUser = new AddTourForUserForm();
            addTourForUser.ShowDialog();
        }
        private void buttonDeleteTourFromUser_Click(object sender, EventArgs e) {
            // wybór 3. opcji - Usuwanie wycieczki klienta
            DeleteTourFromUserForm deleteTourFromUser = new DeleteTourFromUserForm();
            deleteTourFromUser.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e) {
            // wybór 4. opcji - Wyjście z okna
            Close();
        }
    } // class
} // namespace
