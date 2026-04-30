using System;
using System.Collections.Generic;
using UserManagementSystem.Models;
using UserManagementSystem.Utils;

namespace UserManagementSystem.Services
{
    public class AuthService
    {
        private List<User> users = new List<User>();

        public void Register(string username, string password)
        {
            try
            {
                string hashedPassword = PasswordHelper.HashPassword(password);

                users.Add(new User
                {
                    Username = username,
                    HashedPassword = hashedPassword
                });

                Logger.Log("User registered successfully: " + username);
            }
            catch (Exception ex)
            {
                Logger.Log("Error in Register: " + ex.Message);
            }
        }

        public bool Authenticate(string username, string password)
        {
            try
            {
                string hashedPassword = PasswordHelper.HashPassword(password);

                foreach (var user in users)
                {
                    if (user.Username == username &&
                        user.HashedPassword == hashedPassword)
                    {
                        Logger.Log("Login successful for user: " + username);
                        return true;
                    }
                }

                Logger.Log("Login failed for user: " + username);
                return false;
            }
            catch (Exception ex)
            {
                Logger.Log("Error in Authenticate: " + ex.Message);
                return false;
            }
        }
    }
}