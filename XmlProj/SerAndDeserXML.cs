using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace XmlProj
{
    class SerAndDeserXML
    {
        public static void Main()

        {
            School s1 = new School { SchoolName = "crown", SchoolAddress = "shakergunj", Zipcode = 5000078 } ;
            XmlSerializer x1 = new XmlSerializer(typeof(School));
            StreamWriter write = new StreamWriter(@"D:\mohsina\repos\XmlProj\xmldata\school.xml");
            x1.Serialize(write, s1);
            write.Close();
            StreamReader read = new StreamReader(@"D:\mohsina\repos\XmlProj\xmldata\school.xml");
            School desobj=(School)x1.Deserialize(read);
            Console.WriteLine(desobj);
        }
    }
    public class School
    {
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public int Zipcode{ get; set; }

    }
}
