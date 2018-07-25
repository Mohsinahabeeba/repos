using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;
using System.IO;

namespace MyJson

{
    public class Details
    {
        public int studentID;
        public string studentName;
        
    }

    class Program
    {
        public static void Main()
        {
            Details d1 = new Details();
            List<Details> myList = new List<Details>(30);
            StreamReader write1 = new StreamReader(@"D:\readwrite\Demo.txt");

            //  Console.WriteLine("Reading jsconfig1.json");

            //    String jsonString = File.ReadAllText("D:/ mohs / JSONS / MyJson / jsconfig1.json");



            // List<Details> myList = JsonConvert.DeserializeObject<List<Details>>(jsonString);
            if (myList == null)
                myList = new List<Details>();
            String input = "";
            int inputInt = 0;
            string inputString = "";
            while (input!="q")
            {
                Console.WriteLine("press a to write");
                Console.WriteLine("press b to read");
                Console.WriteLine("press q to exit");
                input = Console.ReadLine();
                switch(input)
                {
                    case "a":
                        Console.WriteLine("adding a new item");
                        Console.WriteLine("enter the student name");
                        inputString = Console.ReadLine();
                        Console.WriteLine("enter the id");
                        inputInt = Convert.ToInt32(Console.ReadLine());
                      //  myList.Add(new Details(inputInt, inputString));
                        Console.WriteLine("student name " + inputString + " " + "with id " + inputInt + " " + "has been added");
                        break;
                    case "b":
                        Console.WriteLine("showing contents\n");
                        foreach(Details d2 in myList)
                        {
                            Console.WriteLine("student name" + d1.studentName + "student id" + d1.studentID);
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




            }
            //Console.WriteLine("rewriting the jsconfig1.json");
            StreamWriter writing= new StreamWriter(@"D:\readwrite\Demo.txt");

            Console.WriteLine("new code has been added");
            Console.WriteLine("chsngessssssss");
            // String data = JsonConvert.SerializeObject(myList);
            // File.WriteAllText("D:/ mohs / JSONS / MyJson / jsconfig2.json", data);
            Console.ReadLine();

        }
    }
}