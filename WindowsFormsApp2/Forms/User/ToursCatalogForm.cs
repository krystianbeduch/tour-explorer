using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TourExplorer {
    public partial class ToursCatalogForm : Form {
        public ToursCatalogForm() {
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

        private void ShowAllTrips() {
            // wyświetlenie wszystkich wycieczek
            DataTable dataTable = Session.CurrentSession.DatabaseOracle.GetAllTours();

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
            // utwórz kolumne dla przyciskow
            Label emptyLabel = new Label();
            emptyLabel.Padding = new Padding(5);
            tableLayoutPanel.Controls.Add(emptyLabel, dataTable.Columns.Count, 0);
            
            // wypełnienie kolejnych wierszy
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                for (int j = 0; j < dataTable.Columns.Count; j++) {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    Label label = new Label();
                    label.Text = dataTable.Rows[i][j].ToString();
                    label.Font = new Font(label.Font.FontFamily, 12);
                    label.AutoSize = true;
                    label.Margin = new Padding(5);
                    tableLayoutPanel.Controls.Add(label, j, i + 1);
                } // for j
                
                // dodanie przycisku "Zapisz się na wycieczkę"
                Button button = new Button();
                button.Text = "Zapisz się na wycieczkę";
                button.Name = dataTable.Rows[i]["NAZWA_WYCIECZKI"].ToString();
                button.Font = new Font(button.Font.FontFamily, 10, FontStyle.Bold);
                button.AutoSize = true;
                button.Margin = new Padding(5);
                button.BackColor = Color.Transparent;
                
                // przypisanie zdarzenia kliknięcia przycisku
                button.Click += (sender, e) => {
                    if (Session.CurrentSession.Role == Session.UserRole.RegisteredUser) {
                        int userId = Session.CurrentSession.DatabaseOracle.GetUserId(Session.CurrentSession.Username);
                        int tripId = Session.CurrentSession.DatabaseOracle.GetTripId(button.Name);
                        Session.CurrentSession.DatabaseOracle.SignUserToTour(userId, tripId);
                        MessageBox.Show("Zapisano na wycieczkę", "Gratulację", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Session.CurrentSession.Role == Session.UserRole.Guest) {
                        MessageBox.Show("Aby zapisać się na wycieczkę musisz być zarejestrowanym użytkownikiem",
                            "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }; // Click event
                tableLayoutPanel.Controls.Add(button, dataTable.Columns.Count, i + 1);
            } // for i
        } // ShowAllTrips()

        private string FormatColumnName(string columnName) {
            // Zamień podkreślenia na spacje i zamień pierwszą literę na dużą literę
            string formattedName = columnName.Replace("_", " ");
            formattedName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(formattedName.ToLower());
            return formattedName;
        }

        private void TripsCatalogForm_Load(object sender, EventArgs e) {
            // podczas ładowania okna wyświetl wszystkie wycieczki dostępne w katalogu
            ShowAllTrips();
        }

        private void buttonExitFromTourCatalog_Click(object sender, EventArgs e) {
            // obsługa przycisku "Wyjdź z katalogu"
            Close();
        }
    } // class
} // namespace