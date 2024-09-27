using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWritePOC
{
    internal class WriteToTextFile
    {
        class Program
        {
            static void WriteToTextFile()
            {
                string textContent = "This is a sample text.";
                File.WriteAllText("output.txt", textContent);
                Console.WriteLine("Contents written to output.txt");
            }
        }
    }
}
