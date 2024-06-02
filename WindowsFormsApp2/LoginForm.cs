﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourExplorer {
    public partial class LoginForm : Form {
        private Session _session;
        public string Username { get; private set; }
        public string Password { get; private set; }
        private bool _isAdmin;
        public LoginForm(Session session, bool isAdmin) {
            InitializeComponent();
            this.AcceptButton = buttonLogin;
            _session = session;
            _isAdmin = isAdmin;
            Text = _isAdmin ? "Logowanie administratora" : "Logowanie klienta";
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            Username = textBoxUsername.Text;
            Password = textBoxPassword.Text;
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password)) {
                labelEmptyTextBox.Visible = true;
                return;
            }

            if (_session.Login(Username, Password, _isAdmin)) {
                if (_isAdmin) {
                    MessageBox.Show($"Zalogowano do panelu administracyjnego \nWitaj {Username}", "Zalogowano", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Zalogowano \n" + _session, "Zalogowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            else {
                MessageBox.Show("Błędny login lub hasło", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
