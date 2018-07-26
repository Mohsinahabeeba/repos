using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace XmlProj
{
    class xmlreadwrite
    {
        static void Main(string[] args)
        {
            /*XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@"D:\mohsina\repos\XmlProj\xmldata\student.xml");
            xdoc.Save(Console.Out);*/
            string filename = @"D:\mohsina\repos\XmlProj\xmldata\Employee.xml";
            XmlTextWriter writer = new XmlTextWriter(filename, System.Text.Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteComment("this is the new employee xml file");
            writer.WriteStartElement("Employees");
            for (int i = 1; i <= 3; i++)
            {
                writer.WriteStartElement("employee");
                Console.WriteLine("enter ID for Employee" + i);
                writer.WriteElementString("ID", Console.ReadLine());
                Console.WriteLine("enter name for Employee" + i);
                writer.WriteElementString("name", Console.ReadLine());
                Console.WriteLine("enter Department for Employee" + i);
                writer.WriteElementString("Departement", Console.ReadLine());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
            XmlTextReader xmlText = new XmlTextReader(@"D:\mohsina\repos\XmlProj\xmldata\Employee.xml");
              while(xmlText.Read())
              {
                  if(xmlText.NodeType==XmlNodeType.Element && xmlText.Name=="name")
                  {
                      string s1 = xmlText.ReadElementContentAsString();
                      Console.WriteLine("name= " + s1);
                  }
                  if (xmlText.NodeType == XmlNodeType.Element && xmlText.Name == "ID")
                  {
                      string s2 = xmlText.ReadElementContentAsString();
                      Console.WriteLine("id= " + s2);
                  }
                  if (xmlText.NodeType == XmlNodeType.Element && xmlText.Name == "Department")
                  {
                      string s3 = xmlText.ReadElementContentAsString();
                      Console.WriteLine("Department= " + s3);
                  }
              }
           
        }
    }
}
