using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TourExplorer {
    public partial class MainForm : Form {
        //protected Session _session;
        //private DatabaseOracle _databaseOracle;
        private HelloForm _helloForm;

        //public MainForm() {
          //  InitializeComponent();        }

        public MainForm(HelloForm helloForm) {
            InitializeComponent();
            //_session = session;
            toolStripLabelSessionInfo.Text = Convert.ToString(Session.CurrentSession);
            //_databaseOracle = new DatabaseOracle();
            _helloForm = helloForm;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            //Application.Exit();
            _helloForm.Show();

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
        
        private void ShowClientTrips(Session session) {
            DataTable dataTable = Session.CurrentSession.DatabaseOracle.GetClientsTrips(session.Username);

            // jesli brak wycieczek nie generuj tabeli
            if (dataTable.Rows.Count == 0) {
                tableLayoutPanel.Visible = false;
                panelNoTripsFound.Visible = true;
                buttonBrowseTourCatalogBottom.Visible = false;
                return;
            }

            // Ustawienie AutoSize na true, aby tabela dostosowywała się automatycznie do zawartości
            //tableLayoutPanel.AutoSize = true;

            // Ustawienie minimalnej wielkości wierszy i kolumn (opcjonalnie)
            tableLayoutPanel.RowStyles.Clear();
            //tableLayoutPanel.ColumnStyles.Clear();

            /*
             * procenty
             * 10
             * 30
             * 10
             * 40
             * 10
             */
            //tableLayoutPanel1.ColumnStyles
            // Ustawienie minimalnej wielkości wierszy na 30 pikseli
            //for (int i = 0; i < dataTable.Rows.Count + 1; i++) // +1, aby uwzględnić wiersz z nagłówkami
            //{
            //    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30)); // Wysokość wiersza: 30 pikseli
            //}

            // Ustawienie minimalnej szerokości kolumn na 100 pikseli
            //for (int j = 0; j < dataTable.Columns.Count; j++) {
                //float columnPercentage = GetColumnPercentage(j);
                //tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnPercentage));
            //}

            // Utwórz pierwszy wiersz z nagłówkami
            for (int i = 0; i < dataTable.Columns.Count; i++) {
                // utworzenie nagłówków tabeli

                Label headerLabel = new Label();
                headerLabel.Text = FormatColumnName(dataTable.Columns[i].ColumnName);
                headerLabel.Font = new Font(headerLabel.Font.FontFamily, 12, FontStyle.Bold);
                headerLabel.MaximumSize = new Size(300, 0);
                headerLabel.AutoSize = true;
                headerLabel.Margin = new Padding(5);

                //tableLayoutPanel1.ColumnStyles[i].SizeType = SizeType.AutoSize;

                // Dodaj kontrolkę do odpowiedniej komórki TableLayoutPanel (w pierwszym wierszu)
                tableLayoutPanel.Controls.Add(headerLabel, i, 0);
            }
            
            // utworzenie kolumny dla przycisków
            Label emptyLabel = new Label();
            emptyLabel.Padding = new Padding(5);
            tableLayoutPanel.Controls.Add(emptyLabel, dataTable.Columns.Count, 0);


            for (int i = 0; i < dataTable.Rows.Count; i++) {
                for (int j = 0; j < dataTable.Columns.Count; j++) {
                    // Dodaj nowy wiersz do TableLayoutPanel przed każdym wstawieniem danych
                    //tableLayoutPanel.RowCount++; // Zwiększ liczbę wierszy o 1
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Ustaw nowy wiersz na automatyczny rozmiar
                    bool columnBookingDate = false;
                    string formattedbookingDate = null;
                    if (dataTable.Columns[j].ColumnName.ToUpper() == "DATA_REZERWACJI") {
                        // formatowanie daty na zadany format
                        DateTime bookingDate = DateTime.Parse(dataTable.Rows[i][j].ToString());
                        formattedbookingDate = bookingDate.ToString("dd MMMM yyyy", CultureInfo.CurrentCulture);
                        columnBookingDate = true;
                    }

                    // wypełnienie zawartości wiersza
                    Label label = new Label();
                    label.Text = columnBookingDate ? formattedbookingDate : dataTable.Rows[i][j].ToString();
                    label.Font = new Font(label.Font.FontFamily, 12);
                    //label.MaximumSize = new Size(400, 0);
                    label.AutoSize = true;
                    label.Margin = new Padding(5);

                    // Dodaj kontrolkę do odpowiedniej komórki TableLayoutPanel
                    tableLayoutPanel.Controls.Add(label, j, i + 1);
                }
                // dodanie przycisku "Usuń wycieczkę"
                Button button = new Button();
                button.Text = "Wypisz się z wycieczki";
                button.Name = dataTable.Rows[i]["NUMER_REZERWACJI"].ToString(); // Dodaj numer katalogowy wycieczki do nazwy przycisku
                button.Font = new Font(button.Font.FontFamily, 10);
                button.AutoSize = true;
                button.Margin = new Padding(5);
                button.BackColor = Color.Transparent;
                // przypisanie zdarzenia kliknięcia przycisku
                button.Click += (sender, e) => {
                    if (Session.CurrentSession.Role == Session.UserRole.RegisteredUser) {
                        //Session.CurrentSession.DatabaseOracle.WriteOutUserFromTour(button.Name);
                        int userId = Session.CurrentSession.DatabaseOracle.GetUserId(Session.CurrentSession.Username);
                        int tripId = Session.CurrentSession.DatabaseOracle.GetTripId(button.Name);
                        //MessageBox.Show("userId: " + userId + ", tripId: " + tripId);
                        Session.CurrentSession.DatabaseOracle.SignUserToTour(userId, tripId);
                        MessageBox.Show("Zapisano na wycieczkę", "Gratulację", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Session.CurrentSession.Role == Session.UserRole.Guest) {
                        MessageBox.Show("Aby zapisać się na wycieczkę musisz być zarejestrowanym użytkownikiem",
                            "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }; // Click event
                // Dodaj przycisk do odpowiedniej komórki TableLayoutPanel
                tableLayoutPanel.Controls.Add(button, dataTable.Columns.Count, i + 1);
            
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            ShowClientTrips(Session.CurrentSession);
        }

        private string FormatColumnName(string columnName) {
            // Zamień podkreślenia na spacje i zamień pierwszą literę na dużą literę
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
            //_session = null;
            Close();
            DialogResult = DialogResult.Retry;
            

            //HelloForm helloForm = new HelloForm();
            //helloForm.Show();
        }

        private void clearCurrentTable() {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear();
        }
    }
}