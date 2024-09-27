using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWritePOC
{
    internal class WriteToHtmlFile
    {
        class Program
        {
            static void WriteToHtmlFile()
            {
                string htmlContent = "<html><body><h1>Hello, World!</h1></body></html>";
                File.WriteAllText("output.html", htmlContent);
                Console.WriteLine("Contents written to output.html");
            }
        }
    }
}
