using System;
using System.IO;
using System.Xml.Linq;

using System;
using System.IO;

namespace FileReadWritePOC
{
    class Program
    {
        static void AppendUsernameToFile()
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            string filePath = "usernames.txt";

            // Append the username to the file
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(username);
            }

            Console.WriteLine($"Username '{username}' has been added to {filePath}");
        }

        static void Main(string[] args)
        {
            // Call the case study methods
            ReadFromXmlFile();
            ReadFromHtmlFile();
            ReadFromTextFile();

            WriteToXmlFile();
            WriteToHtmlFile();
            WriteToTextFile();

            AppendUsernameToFile();
        }

        private static void WriteToTextFile()
        {
            throw new NotImplementedException();
        }

        private static void WriteToXmlFile()
        {
            throw new NotImplementedException();
        }

        private static void WriteToHtmlFile()
        {
            throw new NotImplementedException();
        }

        private static void ReadFromTextFile()
        {
            throw new NotImplementedException();
        }

        private static void ReadFromHtmlFile()
        {
            throw new NotImplementedException();
        }

        private static void ReadFromXmlFile()
        {
            throw new NotImplementedException();
        }
    }
}


