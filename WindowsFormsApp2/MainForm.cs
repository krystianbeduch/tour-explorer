using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TourExplorer {
    public partial class MainForm : Form {
        private HelloForm _helloForm;

        public MainForm(HelloForm helloForm) {
            InitializeComponent();
            toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession); // pasek statusu (user)
            _helloForm = helloForm;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            _helloForm.Show();
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
        
        private void ShowClientTrips(Session session) {
            // wyświetlenie wszystkich wycieczek klienta
            DataTable dataTable = Session.CurrentSession.DatabaseOracle.GetClientsTrips(session.Username);

            // jeśli brak wycieczek nie generuj tabeli
            if (dataTable.Rows.Count == 0) {
                tableLayoutPanel.Visible = false;
                panelNoTripsFound.Visible = true;
                buttonBrowseTourCatalogBottom.Visible = false;
                return;
            }

            // utwórzenie 1. wiersza z nagłówkami
            for (int i = 0; i < dataTable.Columns.Count; i++) {
                Label headerLabel = new Label();
                headerLabel.Text = FormatColumnName(dataTable.Columns[i].ColumnName);
                headerLabel.Font = new Font(headerLabel.Font.FontFamily, 12, FontStyle.Bold);
                headerLabel.MaximumSize = new Size(300, 0);
                headerLabel.AutoSize = true;
                headerLabel.Margin = new Padding(5);
                tableLayoutPanel.Controls.Add(headerLabel, i, 0);
            }  
            
            // utwórzenie kolumny dla przycisków
            Label emptyLabel = new Label();
            emptyLabel.Padding = new Padding(5);
            emptyLabel.Size = new Size(120, 50);
            tableLayoutPanel.Controls.Add(emptyLabel, dataTable.Columns.Count, 0);

            // wypełnienie kolejnych wierszy
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                for (int j = 0; j < dataTable.Columns.Count; j++) {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    bool columnBookingDate = false;
                    string formattedbookingDate = null;
                    if (dataTable.Columns[j].ColumnName.ToUpper() == "DATA_REZERWACJI") {
                        // formatowanie daty na zadany format
                        DateTime bookingDate = DateTime.Parse(dataTable.Rows[i][j].ToString());
                        formattedbookingDate = bookingDate.ToString("dd MMMM yyyy", CultureInfo.CurrentCulture);
                        columnBookingDate = true;
                    }
                    Label label = new Label();
                    label.Text = columnBookingDate ? formattedbookingDate : dataTable.Rows[i][j].ToString();
                    label.Font = new Font(label.Font.FontFamily, 12);
                    label.MaximumSize = new Size(200, 0);
                    label.AutoSize = true;
                    label.Margin = new Padding(5);
                    tableLayoutPanel.Controls.Add(label, j, i + 1);
                } // for j

                // dodanie przycisku do usuwania wycieczki
                Button button = new Button();
                button.Text = "X";
                button.Name = dataTable.Rows[i]["NUMER_REZERWACJI"].ToString();
                button.Font = new Font(button.Font.FontFamily, 12, FontStyle.Bold);
                button.AutoSize = true;
                button.Dock = DockStyle.Fill;
                button.Margin = new Padding(5);
                button.BackColor = Color.Transparent;

                // przypisanie zdarzenia kliknięcia przycisku
                button.Click += (sender, e) => {                    
                    Session.CurrentSession.DatabaseOracle.WriteOutUserFromTour(Convert.ToInt32(button.Name));
                    MessageBox.Show($"Usunięto rezerwację numer {button.Name}", "Gratulację", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    clearCurrentTable();
                    ShowClientTrips(Session.CurrentSession);
                    Show();
                }; // Click event
                tableLayoutPanel.Controls.Add(button, dataTable.Columns.Count, i + 1);
            } // for i
        } // ShowClientTrips()

        private void MainForm_Load(object sender, EventArgs e) {
            ShowClientTrips(Session.CurrentSession);
        }

        private string FormatColumnName(string columnName) {
            // zamiana podłóg na spacji, pierwszej litery na dużą
            string formattedName = columnName.Replace("_", " ");
            formattedName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(formattedName.ToLower());
            return formattedName;
        }

        private void buttonBrowseTourCatalog_Click(object sender, EventArgs e) {
            ToursCatalogForm tripsCatalogForm = new ToursCatalogForm();
            Hide();
            if (tripsCatalogForm.ShowDialog() == DialogResult.OK) {
                clearCurrentTable();
                ShowClientTrips(Session.CurrentSession);
            }
            Show();
        }

        private void buttonBrowseTourCatalogBottom_Click(object sender, EventArgs e) {
            buttonBrowseTourCatalog_Click(sender, e);
        }

        private void buttonLogoutUser_Click(object sender, EventArgs e) {
            Close();
            DialogResult = DialogResult.Retry;
        }

        private void clearCurrentTable() {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();
        }
    } // class
} // namespace