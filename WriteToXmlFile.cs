using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileReadWritePOC
{
    internal class WriteToXmlFile
    {
        class Program
        {
            static void WriteToXmlFile()
            {
                XElement newElement = new XElement("NewElement", "This is a new element");
                XElement rootElement = new XElement("Root", newElement);
                rootElement.Save("output.xml"); // Saves to an XML file
                Console.WriteLine("Contents written to output.xml");
            }
        }
    }
}
