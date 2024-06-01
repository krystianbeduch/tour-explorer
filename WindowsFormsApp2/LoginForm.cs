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
    public partial class LoginForm : Form {
        private Session _session;
        public string Username { get; private set; }
        public string Password { get; private set; }
        public LoginForm(Session session) {
            InitializeComponent();
            this.AcceptButton = buttonLogin;
            _session = session;
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            Username = textBoxUsername.Text;
            Password = textBoxPassword.Text;

            if (_session.LoginAsUser(Username, Password)) {
                MessageBox.Show("Zalogowano \n" + _session);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("Błędny login lub hasło");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
