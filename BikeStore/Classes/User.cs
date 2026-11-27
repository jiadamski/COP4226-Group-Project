using System;
using System.Collections.Generic;
using System.Linq;
using dbUser = BikeStore.User;

namespace BikeStore.Classes
{
    public class User : Person
    {
        public static User LoggedUser { get; private set; }

        public static bool IsLoggedIn => LoggedUser != null && LoggedUser.IsAuthenticated;

        public int UserId { get; private set; }

        public string Username { get; set; }

        public string Role { get; set; }

        public bool IsActive { get; set; }

        public bool IsAuthenticated { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public DateTime ModifiedDate { get; private set; }

        public DateTime? LastLoginDate { get; private set; }

        public User()
        {
            Role = "Employee";
            IsActive = true;
            IsAuthenticated = false;
        }

        public bool Authenticate(string username, string password)
        {
            Logout();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            using (var db = new BikeStoreEntities())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.IsActive);

                if (user == null)
                {
                    return false;
                }

                if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                {
                    return false;
                }

                user.LastLoginDate = DateTime.Now;
                db.SaveChanges();

                LoadUserInformation(user);

                IsAuthenticated = true;
                LoggedUser = this;

                return true;
            }
        }

        private static void ValidateAdminAccess()
        {
            if (!IsLoggedIn)
            {
                throw new UnauthorizedAccessException("Authentication is required.");
            }

            using (var db = new BikeStoreEntities())
            {
                var user = db.Users.Find(LoggedUser.UserId);

                if (user == null || !user.IsActive || user.Role != "Admin")
                {
                    throw new UnauthorizedAccessException("Administrator access is required.");
                }
            }
        }

        private void ValidateUserInformation()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                throw new ArgumentException(
                    "Username is required.");
            }

            if (string.IsNullOrWhiteSpace(FirstName))
            {
                throw new ArgumentException(
                    "First name is required.");
            }

            if (string.IsNullOrWhiteSpace(LastName))
            {
                throw new ArgumentException(
                    "Last name is required.");
            }

            if (Role != "Admin" && Role != "Employee")
            {
                throw new ArgumentException("Invalid user role.");
            }
        }

        public void AddUser(string password)
        {
            ValidateAdminAccess();
            ValidateUserInformation();

            if (string.IsNullOrWhiteSpace(password) ||  password.Length < 12 ||  password.Any(char.IsWhiteSpace))
            {
                throw new ArgumentException("Password must be at least 12 characters without spaces.");
            }

            using (var db = new BikeStoreEntities())
            {
                bool exists = db.Users.Any(u => u.Username == this.Username);

                if (exists)
                {
                    throw new InvalidOperationException("Username already exists.");
                }

                var newUser = new dbUser
                {
                    Username = this.Username,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(password),
                    FirstName = this.FirstName,
                    MiddleName = this.MiddleName,
                    LastName = this.LastName,
                    EmailAddress = this.EmailAddress,
                    Phone = this.Phone,
                    Role = this.Role,
                    IsActive = this.IsActive,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                LoadUserInformation(newUser);
            }
        }


        public void UpdateUser(string newPassword = null)
        {
            ValidateAdminAccess();
            ValidateUserInformation();

            if (newPassword != null &&
                (string.IsNullOrWhiteSpace(newPassword) ||
                 newPassword.Length < 8 ||
                 newPassword.Any(char.IsWhiteSpace)))
            {
                throw new ArgumentException(
                    "Password must be at least 8 characters without spaces.");
            }

            using (var db = new BikeStoreEntities())
            {
                var user = db.Users.Find(UserId)
                    ?? throw new InvalidOperationException(
                        "User not found.");

                bool exists = db.Users.Any(u =>
                    u.Username == Username &&
                    u.UserID != UserId);

                if (exists)
                {
                    throw new InvalidOperationException(
                        "Username already exists.");
                }

                user.Username = Username;
                user.FirstName = FirstName;
                user.MiddleName = MiddleName;
                user.LastName = LastName;
                user.EmailAddress = EmailAddress;
                user.Phone = Phone;
                user.Role = Role;
                user.IsActive = IsActive;

                // Update password only when requested.
                if (newPassword != null)
                {
                    user.PasswordHash =
                        BCrypt.Net.BCrypt.HashPassword(newPassword);
                }

                user.ModifiedDate = DateTime.Now;

                // Save all changes together.
                db.SaveChanges();

                ModifiedDate = user.ModifiedDate;
            }
        }


        public void DeleteUser()
        {
            ValidateAdminAccess();

            if (UserId == LoggedUser.UserId)
            {
                throw new InvalidOperationException(
                    "You cannot delete your own account.");
            }

            using (var db = new BikeStoreEntities())
            {
                var user = db.Users.Find(UserId)
                    ?? throw new InvalidOperationException(
                        "User not found.");

                if (user.Role == "Admin" && user.IsActive)
                {
                    bool anotherAdminExists = db.Users.Any(u => u.UserID != UserId && u.Role == "Admin" && u.IsActive);

                    if (!anotherAdminExists)
                    {
                        throw new InvalidOperationException("You cannot delete the last active administrator.");
                    }
                }

                db.Users.Remove(user);

                db.SaveChanges();
            }
        }

        public void ToggleUserStatus()
        {
            ValidateAdminAccess();

            if (UserId == LoggedUser.UserId)
            {
                throw new InvalidOperationException("You cannot change your own account status.");
            }

            using (var db = new BikeStoreEntities())
            {
                var user = db.Users.Find(UserId) ?? throw new InvalidOperationException("User not found.");

                user.IsActive = !user.IsActive;
                user.ModifiedDate = DateTime.Now;

                db.SaveChanges();

                IsActive = user.IsActive;
                ModifiedDate = user.ModifiedDate;
            }
        }

        public bool ChangePassword(string currentPassword, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword))
            {
                return false;
            }

            using (var db = new BikeStoreEntities())
            {
                var user = db.Users.Find(UserId);

                if (user == null || !user.IsActive)
                {
                    return false;
                }

                if (!BCrypt.Net.BCrypt.Verify(currentPassword, user.PasswordHash))
                {
                    return false;
                }

                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
                user.ModifiedDate = DateTime.Now;
                db.SaveChanges();

                ModifiedDate = user.ModifiedDate;

                return true;
            }
        }

        public static List<User> GetUsers()
        {
            ValidateAdminAccess();

            using (var db = new BikeStoreEntities())
            {
                var dbUsers = db.Users.OrderBy(u => u.UserID).ToList();

                List<User> users = new List<User>();

                foreach (var dbUser in dbUsers)
                {
                    User user = new User();

                    user.LoadUserInformation(dbUser);

                    users.Add(user);
                }

                return users;
            }
        }

        public bool GetUserInformation(int userID)
        {
            Logout();

            using (var db = new BikeStoreEntities())
            {
                var user = db.Users.Find(userID);

                if (user == null)
                {
                    return false;
                }

                LoadUserInformation(user);

                return true;
            }
        }
        private void LoadUserInformation(dbUser user)
        {
            UserId = user.UserID;
            Username = user.Username;

            FirstName = user.FirstName;
            MiddleName = user.MiddleName;
            LastName = user.LastName;
            EmailAddress = user.EmailAddress;
            Phone = user.Phone;

            Role = user.Role;
            IsActive = user.IsActive;
            CreatedDate = user.CreatedDate;
            ModifiedDate = user.ModifiedDate;
            LastLoginDate = user.LastLoginDate;
        }

        public void Logout()
        {
            IsAuthenticated = false;

            if (LoggedUser == this)
            {
                LoggedUser = null;
            }
        }
    }
}