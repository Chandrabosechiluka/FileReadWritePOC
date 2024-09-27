using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWritePOC
{
    internal class ReadFromTextFile
    {
        class Program
        {
            static void ReadFromTextFile()
            {
                string filePath = "sample.txt"; 
                if (File.Exists(filePath))
                {
                    string textContent = File.ReadAllText(filePath);
                    Console.WriteLine("Contents of the text file:");
                    Console.WriteLine(textContent);
                }
                else
                {
                    Console.WriteLine("Text file not found.");
                }
            }
        }
    }
}
