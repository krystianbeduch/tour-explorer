using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace TourExplorer {
    public partial class TripsCatalogForm : Form {
        private Session _session;
        private DatabaseOracle _databaseOracle;

        public TripsCatalogForm(Session _session) {
            InitializeComponent();
            _databaseOracle = new DatabaseOracle();
        }

        private void TripsCatalogForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void ShowAllTrips() {
            DataTable dataTable = _databaseOracle.GetAllTrips();
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

            // utworz kolumne dla przyciskow
            Label emptyLabel = new Label();
            emptyLabel.Padding = new Padding(5);
            tableLayoutPanel.Controls.Add(emptyLabel, dataTable.Columns.Count, 0);


            for (int i = 0; i < dataTable.Rows.Count; i++) {
                for (int j = 0; j < dataTable.Columns.Count; j++) {
                    // Dodaj nowy wiersz do TableLayoutPanel przed każdym wstawieniem danych
                    //tableLayoutPanel.RowCount++; // Zwiększ liczbę wierszy o 1
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Ustaw nowy wiersz na automatyczny rozmiar

                    // Utwórz kontrolkę (np. Label) i ustaw jej wartość na dane z DataTable
                    Label label = new Label();
                    label.Text = dataTable.Rows[i][j].ToString();
                    label.Font = new Font(label.Font.FontFamily, 12);
                    //label.MaximumSize = new Size(400, 0);
                    label.AutoSize = true;
                    label.Margin = new Padding(5);

                    // Dodaj kontrolkę do odpowiedniej komórki TableLayoutPanel
                    tableLayoutPanel.Controls.Add(label, j, i + 1);
                }
                Button button = new Button();
                button.Text = "Zapisz się na wycieczkę";
                button.Name = "buttonSignIn" + dataTable.Rows[i]["NUMER_KATALOGOWY_WYCIECZKI"].ToString(); // Dodaj numer katalogowy wycieczki do nazwy przycisku
                button.Font = new Font(button.Font.FontFamily, 10);
                button.AutoSize = true;
                button.Margin = new Padding(5);
                button.BackColor = Color.Transparent;
                // Przypisz zdarzenie kliknięcia przycisku
                button.Click += (sender, e) => {
                    // Tutaj umieść kod obsługi zapisu użytkownika na wycieczkę
                    // Możesz użyć np. button.Name lub dataTable.Rows[i][j - 1] do identyfikacji wycieczki
                };
                // Dodaj przycisk do odpowiedniej komórki TableLayoutPanel
                tableLayoutPanel.Controls.Add(button, dataTable.Columns.Count, i + 1);
            }
        }                  

        private string FormatColumnName(string columnName) {
            // Zamień podkreślenia na spacje i zamień pierwszą literę na dużą literę
            string formattedName = columnName.Replace("_", " ");
            formattedName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(formattedName.ToLower());
            return formattedName;
        }

        private void TripsCatalogForm_Load(object sender, EventArgs e) {
            ShowAllTrips();
        }
    }
}
