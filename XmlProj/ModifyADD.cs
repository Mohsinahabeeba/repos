using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlProj
{
    class ModifyADD
    {
        public static void Main()
        {
            XDocument xs = XDocument.Load(@"D:\mohsina\repos\XmlProj\xmldata\newdata.xml");
            //adding
            /*  xs.Element("Students").Add(new XElement("student", new XAttribute("id", 105),
                  new XElement("name", "Julie"),
                  new XElement("total", "1000")));*/
           //modifying
           /*xs.Element("Students").
                Elements("student").
               Where(x => x.Attribute("id").Value == "102").FirstOrDefault()
                .SetElementValue("total", 676);*/
                //deleting
            xs.Root.Elements().Where(x =>x.Attribute("id").Value == "102").FirstOrDefault().Remove();
            xs.Save(@"D:\mohsina\repos\XmlProj\xmldata\newdata.xml");
        }
    }

}
