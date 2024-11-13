using System;
using System.IO;

namespace SauceDemoAutomation.Utilities
{
    public static class Utilities
    {
        public static void LogMessage(string message)
        {
            string filePath = "TestLogs.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}