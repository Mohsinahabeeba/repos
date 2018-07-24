using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class StudList
    {

        private int studentID;
        private string studentName;
        public StudList(int studentID, string studentName)
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
        public static void Main()

        {
            // StudList d1 = new StudList();
            List<StudList> myList = new List<StudList>();
            if (myList == null)
                myList = new List<StudList>();
            String input = "";
            int inputInt = 0;
            string inputString = "";
            do
            {
                Console.WriteLine("press a to write");
                Console.WriteLine("press b to read");
                Console.WriteLine("press q to exit");
                input = Console.ReadLine();
                switch (input)
                {
                    case "a":
                        Console.WriteLine("adding a new item");
                        Console.WriteLine("enter the student name");
                        inputString = Console.ReadLine();
                        Console.WriteLine("enter the id");
                        inputInt = Convert.ToInt32(Console.ReadLine());
                        myList.Add(new StudList(inputInt, inputString));
                        File.WriteAllText(@"D:\readwrite\Demo.txt", myList.ToString());
                        Console.WriteLine("student name= " + inputString + " " + "with id =" + inputInt + " " + "has been added");
                        break;
                    case "b":
                        Console.WriteLine("showing contents\n");
                        foreach (StudList d2 in myList)
                        {
                            Console.WriteLine("student name=" + d2.studentName + "student id=" + d2.studentID);
                            string content = File.ReadAllText(@"D:\readwrite\Demo.txt");

                            Console.WriteLine(content);
                        }
                        Console.WriteLine("\n");

                        break;
                    case "q":
                        Console.WriteLine("quit program\n");
                        break;

                    default:
                        Console.WriteLine("incorrect command try again");
                        break;

                }
            } while (input != "q");
        }
    }
}