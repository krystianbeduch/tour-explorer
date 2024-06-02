using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TourExplorer {
    public partial class MainForm : Form {
        private Session _session;
        private DatabaseOracle _databaseOracle;
        private HelloForm _helloForm;

        public MainForm(Session session, HelloForm helloForm) {
            InitializeComponent();
            _session = session;
            toolStripLabelSessionInfo.Text = Convert.ToString(_session);
            _databaseOracle = new DatabaseOracle();
            _helloForm = helloForm;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            //Application.Exit();
            _helloForm.Show();

        }

        private void toolStripButtonDataBaseCheck_Click(object sender, EventArgs e) {
            if (_databaseOracle.CheckConnection()) {
                toolStripStatusLabelDataBase.Text = "Połączono z bazą danych Oracle";
                toolStripStatusLabelDataBase.ForeColor = Color.ForestGreen;
            }
            else {
                toolStripStatusLabelDataBase.Text = "Błąd podczas łączenia z bazą danych Oracle";
                toolStripStatusLabelDataBase.ForeColor = Color.Red;
            }
        }
        
        private void ShowClientTrips(Session session) {
            DataTable dataTable = _databaseOracle.GetClientsTrips(session.Username);

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

                    // Utwórz kontrolkę (np. Label) i ustaw jej wartość na dane z DataTable
                    Label label = new Label();
                    label.Text = columnBookingDate ? formattedbookingDate : dataTable.Rows[i][j].ToString();
                    label.Font = new Font(label.Font.FontFamily, 12);
                    //label.MaximumSize = new Size(400, 0);
                    label.AutoSize = true;
                    label.Margin = new Padding(5);

                    // Dodaj kontrolkę do odpowiedniej komórki TableLayoutPanel
                    tableLayoutPanel.Controls.Add(label, j, i + 1);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            ShowClientTrips(_session);
        }

        private string FormatColumnName(string columnName) {
            // Zamień podkreślenia na spacje i zamień pierwszą literę na dużą literę
            string formattedName = columnName.Replace("_", " ");
            formattedName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(formattedName.ToLower());
            return formattedName;
        }

        private void buttonBrowseTourCatalog_Click(object sender, EventArgs e) {
            TripsCatalogForm tripsCatalogForm = new TripsCatalogForm(_session);
            Hide();
            tripsCatalogForm.ShowDialog();
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
    }
}