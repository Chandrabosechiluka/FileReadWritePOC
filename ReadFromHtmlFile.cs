using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWritePOC
{
    internal class ReadFromHtmlFile
    {
        class Program
        {
            static void ReadFromHtmlFile()
            {
                string filePath = "sample.html"; 
                if (File.Exists(filePath))
                {
                    string htmlContent = File.ReadAllText(filePath);
                    Console.WriteLine("Contents of the HTML file:");
                    Console.WriteLine(htmlContent);
                }
                else
                {
                    Console.WriteLine("HTML file not found.");
                }
            }
        }
    }
}
