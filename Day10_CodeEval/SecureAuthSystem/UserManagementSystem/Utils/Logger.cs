using System;
using System.IO;

namespace UserManagementSystem.Utils
{
    public class Logger
    {
        private static string path = "log.txt";

        public static void Log(string message)
        {
            File.AppendAllText(path,
                $"{DateTime.Now} - {message}\n");
        }
    }
}