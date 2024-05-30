using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp2 {
    /// <summary>
    /// Klasa odpowiedzialna za operacje bazodanowe na bazie Oracle
    /// </summary>
    public class DatabaseOracle {
        private readonly string _connectionString; // łańcuch połączenia z bazą
        public DatabaseOracle(string connectionString) {
            _connectionString = connectionString;
        }
        public OracleConnection GetConnection() {
            return new OracleConnection(_connectionString); // połączenie do bazy
        }
        public string GetPasswordForUser(string username) {
            string password = "";
            using (OracleConnection connection = GetConnection()) {
                string query = "SELECT haslo FROM klienci WHERE login = :username";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter("username", username)); // dodanie parametru do zapytania
                try {
                    connection.Open(); // otwarcie połączenia z bazą
                    OracleDataReader reader = command.ExecuteReader(); // wykonanie zapytania SQL

                    if (reader.Read()) { // jeśli znaleziono dane
                        password = reader["haslo"].ToString(); // z kolumny "haslo" odczytaj dane i zapisz do zmiennej
                    }
                }
                catch (Exception ex) {
                    /*MessageBox.Show("Błąd podczas łączenia z bazą danych Oracle: " + ex.Message);
                    toolStripStatusLabelDataBase.Text = "Błąd podczas łączenia z bazą danych Oracle:" + ex.Message;
                    toolStripStatusLabelDataBase.ForeColor = Color.Red;*/
                }
                finally {
                    connection.Close(); // zamknięcie połączenia z bazą
                }
            }
            return password;
        }
    }
}
