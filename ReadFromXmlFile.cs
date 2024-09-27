using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileReadWritePOC
{
    internal class ReadFromXmlFile
    {
        class Program
        {
            static void ReadFromXmlFile()
            {
                string filePath = "sample.xml"; 
                if (System.IO.File.Exists(filePath))
                {
                    XElement xmlContent = XElement.Load(filePath);
                    Console.WriteLine("Contents of the XML file:");
                    Console.WriteLine(xmlContent);
                }
                else
                {
                    Console.WriteLine("XML file not found.");
                }
            }
        }
    }
}
