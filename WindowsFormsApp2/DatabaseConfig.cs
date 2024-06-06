using System;
/// <summary>
/// Klasa reprezentująca konfigurację połączenia z bazą danych
/// Zawiera informacje o źródle danych, identyfikator użytkownika oraz hasło
/// </summary>
[Serializable]
public class DatabaseConfig {
    public string DataSource { get; set; }
    public string UserId { get; set; }
    public string Password { get; set; }
}