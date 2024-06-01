using System;
using System.Data;
using System.IO;
using System.Xml.Serialization;
using Oracle.ManagedDataAccess.Client;

namespace TourExplorer {
    /// <summary>
    /// Klasa odpowiedzialna za operacje bazodanowe na bazie Oracle
    /// </summary>
    public class DatabaseOracle {
        private string DataSource { get; set; }
        private string UserId { get; set; }
        private string Password { get; set; }
        private readonly string _connectionString; // łańcuch połączenia z bazą

        public DatabaseOracle() {
            var config = LoadConfig();
            _connectionString = $"Data Source={config.DataSource};User Id={config.UserId};Password={config.Password};";
        }

        private DatabaseConfig LoadConfig() {
            var configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DBConfig.xml");
            if (!File.Exists(configFilePath)) {
                throw new FileNotFoundException("Nie znaleziono pliku konfiguracyjnego do bazy danych", configFilePath);
            }
            try {
                DatabaseConfig databaseConfig;
                var serializer = new XmlSerializer(typeof(DatabaseConfig));
                using (var reader = new StreamReader(configFilePath)) {
                    databaseConfig = (DatabaseConfig)serializer.Deserialize(reader);
                }
                if (    string.IsNullOrEmpty(databaseConfig.DataSource) || 
                        string.IsNullOrEmpty(databaseConfig.UserId) ||
                        string.IsNullOrEmpty(databaseConfig.Password)) 
                {
                    throw new InvalidOperationException("Plik konfiguracyjny zawiera puste wartości");
                }
                return databaseConfig;
            }
            catch (Exception ex) {
                throw new InvalidOperationException("Błąd podczas ładownaia pliku konfiguracyjnego bazy danych");
            }
        }

        public OracleConnection GetConnection() {
            return new OracleConnection(_connectionString); // połączenie do bazy
        }

        public bool CheckConnection() {
            using (OracleConnection connection = GetConnection()) {
                try {
                    connection.Open();
                    return true;
                }
                catch (Exception ex) {
                    Console.WriteLine("Błąd podczas próby połączenia z bazą danych: " + ex.Message);
                    return false;
                }
            }
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
                    Console.WriteLine(ex);
                }
                finally {
                    connection.Close(); // zamknięcie połączenia z bazą
                }
            }
            return password;
        }

        public DataTable GetClientsTrips(string username) {
            DataTable dataTable = new DataTable();
            using (OracleConnection connection = GetConnection()) {
                string query = @"SELECT 
                                    id_wycieczki_klienta AS numer_rezerwacji, 
                                    nazwa_wycieczki, 
                                    CONCAT(cena_wycieczki, ' PLN') AS cena_wycieczki, 
                                    miejsce_odbioru,   
                                    data_rezerwacji 
                                FROM wycieczki_klientow 
                                JOIN klienci USING(id_klienta) 
                                JOIN wycieczki USING(id_katalogowe_wycieczki)
                                WHERE id_klienta = (
                                    SELECT id_klienta FROM klienci WHERE login = :username
                                )";
                using (OracleCommand command = new OracleCommand(query, connection)) {
                    command.Parameters.Add(new OracleParameter("username", username));
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command)) {
                        try {
                            connection.Open();
                            adapter.Fill(dataTable);
                        }
                        catch (Exception ex) {
                            Console.WriteLine("Błąd podczas pobierania danych z bazy danych: " + ex.Message);
                        }
                        finally {
                            connection.Close(); // zamknięcie połączenia z bazą
                        }
                    }
                }
                return dataTable;
            }
        }

        public DataTable GetAllTrips() {
            DataTable dataTable = new DataTable();
            using (OracleConnection connection = GetConnection()) {
                string query = @"SELECT 
                                    id_katalogowe_wycieczki AS numer_katalogowy_wycieczki,
                                    nazwa_wycieczki,
                                    CONCAT(cena_wycieczki, ' PLN') AS cena_wycieczki
                                FROM wycieczki";
                using (OracleCommand command = new OracleCommand(query, connection)) {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command)) {
                        try {
                            connection.Open();
                            adapter.Fill(dataTable);
                        }
                        catch (Exception ex) {
                            Console.WriteLine("Błąd podczas pobierania danych z bazy danych: " + ex.Message);
                        }
                        finally {
                            connection.Close(); // zamknięcie połączenia z bazą
                        }
                    }
                }
            }
            return dataTable;
        }
    }
}
