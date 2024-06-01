using System;

namespace TourExplorer {
    public class Session {

        public enum UserRole {
            Guest,
            RegisteredUser,
            Admin
        }
        public string Username { get; private set; }
        public UserRole Role { get; private set; }


        private static Random random = new Random();
        private readonly DatabaseOracle _databaseOracle;

        public Session(DatabaseOracle databaseOracle) {
            _databaseOracle = databaseOracle;
        }

        public bool LoginAsUser(string username, string password) {
            // pobierz hasło z bazy Oracle, jeśli jest prawidłowe zaloguj użytkownika
            string passwordFromDB = _databaseOracle.GetPasswordForUser(username);
            if (password == passwordFromDB) {
                Username = username;
                Role = UserRole.RegisteredUser;
                return true;
            }
            return false;
        }
        public void LoginAsGuest() {
            // logowanie jako gość
            int randomNumber = random.Next(10000, 100000);
            Username = "User" + randomNumber;
            Role = UserRole.Guest;
        }

        public override string ToString() {
            return $"Użytkownik: {Username}, rola: {Role}";
        }
    }
}
