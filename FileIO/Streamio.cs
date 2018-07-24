using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO

{
    public class Details
    {
         public int studentID;
         public  string studentName;
        public Details(int studentID, string studentName)
        {
            this.studentID = studentID;
            this.studentName = studentName;
        }
      /*  public string Name
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public int Identity
        {
            get { return studentID; }
            set { studentID = value; }
        }*/
    }

    public class Streamio
    {
        static void Main(string[] args)

        {
            Streamio st = new Streamio();
            Details ds = new Details(10,"raju");
            List<Details> myList = new List<Details>();
            string filepath = @"D:\readwrite\Demo.txt";
            Console.WriteLine("insert 1 to write 2 to read");
            int input = int.Parse(Console.ReadLine());
            int inputInt = 0;
            string inputString = "";
            if (input==1)
            {
                Console.WriteLine("plz write to file ");

                
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("enter id of student");
                   inputInt=int.Parse( Console.ReadLine());
                    Console.WriteLine("enter name of student");
                    inputString=Console.ReadLine();
                    //List<Details> myList = new List<Details>();
                    myList.Add(new Details(inputInt,inputString));
                }
                st.WriteForFile(filepath);
            }
            else if(input==2)
            {
                foreach (Details d2 in myList)
                {
                    Console.WriteLine("student name" + d2.studentName + "student id" + d2.studentID);
                }
                Console.WriteLine("\n");
                st.ReadForFile(filepath);
            }
            else
            {
                Console.WriteLine("plz enter valid option");
            }
           
            Console.ReadLine();

        }
        public  void ReadForFile(string filepath)

        {


            FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate,FileAccess.ReadWrite);
                StreamReader read1 = new StreamReader(fs);
            
            Console.WriteLine("\n");

            string r = read1.ReadToEnd();
            Console.WriteLine(r);
            fs.Close();
                read1.Close();
            
            
                
        }
        public void WriteForFile(string filepath)
        {
            FileStream fe = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
               StreamWriter write1 = new StreamWriter(fe);
            string ans;
            ans = Console.ReadLine();
            write1.Write(ans);
            write1.Close();
            fe.Close();

     
            

        }
    }
}
