using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlProj
{
    class XmlDoc
    {
        public static void Main()
        {
            XDocument xdc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), new XComment("craeting xml document using xml linq"),
                new XElement("Students",
                new XElement("student1", new XAttribute("id", 101),
                new XElement("name", "john"),
                new XElement("gender", "Male"),
                new XElement("total", "900")),
                 new XElement("student2", new XAttribute("id", 102),
                new XElement("name", "jack"),
                new XElement("gender", "Male"),
                new XElement("total", "800")),
                  new XElement("student3", new XAttribute("id", 103),
                new XElement("name", "mary"),
                new XElement("gender", "female"),
                new XElement("total", "850"))));
            xdc.Save(@"D:\mohsina\repos\XmlProj\xmldata\newdata.xml");


        }
    }
}
