using System;
using UserManagementSystem.Services;
using UserManagementSystem.Utils;

class Program
{
    static void Main()
    {
        var authService = new AuthService();

        authService.Register("user1", "password123");

        bool isAuthenticated = authService.Authenticate("user1", "password123");

        Console.WriteLine(isAuthenticated ? "Login Success" : "Login Failed");

        string original = "Sensitive Data";
        string encrypted = EncryptionHelper.Encrypt(original);
        Console.WriteLine("Encrypted: " + encrypted);

        string decrypted = EncryptionHelper.Decrypt(encrypted);
        Console.WriteLine("Decrypted: " + decrypted);

        Logger.Log("Application executed successfully");
    }
}