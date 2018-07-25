using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class DictionList
    {
        private int studentID;
        private string studentName;
      /* public DictionList(int studentID, string studentName)
        {
            this.studentID = studentID;
            this.studentName = studentName;
        }*/

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
            DictionList dl = new DictionList();
            Dictionary<int, DictionList> diction = new Dictionary<int, DictionList>();
            String input = "";
            FileStream fe = new FileStream(@"D:\readwrite\Demo.txt", FileMode.Append, FileAccess.Write);
            StreamWriter write1 = new StreamWriter(fe);
            dl.Name = Console.ReadLine();
            write1.Write(dl.Name);
           // fe.Close();
           //write1.Close();

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
                       dl.Name = Console.ReadLine();
                      write1.Write(dl.Name);
                        Console.WriteLine("enter the id");
                        dl.Identity = Convert.ToInt32(Console.ReadLine());
                        write1.Write(dl.Identity);
                        if (!diction.ContainsKey(dl.Identity))
                        {
                         
                           
                            //string ans="mohsina";
                           // ans = Console.ReadLine();
                            //Console.WriteLine("uuuuuuu"+ans);
                          //write1.WriteLine(ans);
                            diction.Add(dl.Identity, dl);
                           // FileStream fe = new FileStream(@"D:\readwrite\Demo.txt", FileMode.OpenOrCreate, FileAccess.Write);
                           // StreamWriter write1 = new StreamWriter(fe);
                           // string ans = "";
                           //ans = diction.ToString();
                           // write1.Write(ans);
                            //write1.Close();
                            //fe.Close();
                            //File.WriteAllText(@"D:\readwrite\Demo.txt", diction.ToString());
                            Console.WriteLine("student name= " + dl.Name + " " + "with id =" + dl.Identity + " " + "has been added");
                        }
                        else
                        {
                            Console.WriteLine("the key already exists");
                        }
                        
                        
                        break;
                    case "b":
                        Console.WriteLine("showing contents\n");
                        foreach (KeyValuePair<int,DictionList> d2 in diction)
                        {
                            Console.WriteLine("key="+d2.Key);
                            DictionList v1 = d2.Value;
                            Console.WriteLine("ID={0},Name={1}", v1.Identity, v1.Name);
                            FileStream fs = new FileStream(@"D:\readwrite\Demo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                            StreamReader read1 = new StreamReader(fs);

                            Console.WriteLine("\n");

                            string r = read1.ReadToEnd();
                            Console.WriteLine(r);
                            fs.Close();
                            read1.Close();

                            //string content = File.ReadAllText(@"D:\readwrite\Demo.txt");

                            //Console.WriteLine(content);
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
            Console.WriteLine("new code has been added");
            Console.WriteLine("chsngessssssss made");
            Console.WriteLine("new code has been added");
            Console.WriteLine("chsngessssssss made");
        }
    }
}
