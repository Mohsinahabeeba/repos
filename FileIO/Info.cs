using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIO
{
    class Info
    {
        private int studentID;
        private string studentName;
         public Info(int studentID, string studentName)
          {
              this.studentID = studentID;
              this.studentName = studentName;
          }

        public string Name
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public int Identity
        {
            get { return studentID; }
            set { studentID = value; }
        }
    }
  

}
