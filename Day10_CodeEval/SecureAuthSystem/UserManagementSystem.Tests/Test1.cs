using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagementSystem.Services;
using UserManagementSystem.Utils;
using System.IO;

namespace UserManagementSystem.Tests
{
    [TestClass]
    public class AuthTests
    {
        [TestMethod]
        public void Register_And_Login_ShouldWork()
        {
            var auth = new AuthService();

            auth.Register("testUser", "123");

            bool result = auth.Authenticate("testUser", "123");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Authenticate_InvalidUser_ShouldReturnFalse()
        {
            var auth = new AuthService();

            bool result = auth.Authenticate("wrongUser", "wrongPass");

            Assert.IsFalse(result);
        }
    }

    [TestClass]
    public class EncryptionTests
    {
        [TestMethod]
        public void Encrypt_Decrypt_ShouldMatch()
        {
            string data = "Hello";

            string encrypted = EncryptionHelper.Encrypt(data);
            string decrypted = EncryptionHelper.Decrypt(encrypted);

            Assert.AreEqual(data, decrypted);
        }
    }

    [TestClass]
    public class LoggingTests
    {
        [TestMethod]
        public void Logger_ShouldWriteToFile()
        {
            string message = "Test log entry";

            Logger.Log(message);

            System.Threading.Thread.Sleep(100);

            string path = "log.txt";

            Assert.IsTrue(File.Exists(path));

            string content = File.ReadAllText(path);

            Assert.IsTrue(content.Contains(message));
        }
    }
}