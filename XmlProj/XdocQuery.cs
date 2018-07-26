using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlProj
{
    class XdocQuery
    {
        public static void Main()
        {
            IEnumerable<string> names = from student in XDocument.Load(@"D:\mohsina\repos\XmlProj\xmldata\newdata.xml").Descendants("student")
                                        where (int)student.Element("total") > 800
                                        orderby (int)student.Element("total") descending
                                        select student.Element("name").Value;
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
