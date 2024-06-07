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
        //private readonly DatabaseOracle _databaseOracle;
        private DatabaseOracle _databaseOracle;
        public DatabaseOracle DatabaseOracle {
            get { return _databaseOracle; }
            set { _databaseOracle = value; }
        }

        private static Session _currentSession;
        public static Session CurrentSession {
            get => _currentSession;
            set => _currentSession = value; /////////////////////////////////
        }

        public Session(DatabaseOracle databaseOracle) {
            DatabaseOracle = databaseOracle;
        }

        public bool Login(string username, string inputPassword, bool isAdmin) {
            // pobierz hasło z bazy Oracle, jeśli jest prawidłowe zaloguj użytkownika
            string passwordHashFromDB = DatabaseOracle.GetPasswordHash(username, isAdmin);
            if (PasswordHashing.VerifyMD5Hash(inputPassword, passwordHashFromDB)) {
                Role = isAdmin ? UserRole.Admin : UserRole.RegisteredUser;
                Username = username;
                CurrentSession = this;
                return true;
            }
            return false;
        }
        public void LoginAsGuest() {
            // logowanie jako gość
            int randomNumber = random.Next(10000, 100000);
            Username = "User" + randomNumber;
            Role = UserRole.Guest;
            CurrentSession = this;
        }

        public override string ToString() {
            return $"Aktualna sesja - użytkownik: {Username}, rola: {Role}";
        }
    } // class
} // namespace
