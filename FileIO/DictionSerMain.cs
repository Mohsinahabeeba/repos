using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class DictionSerMain
    {
        private static string programName =
       Path.GetFileNameWithoutExtension(System.AppDomain.CurrentDomain.FriendlyName);

        public static void Main(string[] args)
        {

            if (args.Length < 1)
            {
                PrintUsage();
            }
            else
            {
                //Info st = new Info();
                StudentsInformation fi = StudentsInformation.Instance();
                fi.Load();

                String command = args[0].ToLower();

                if (command == "list")
                {
                    fi.Print();
                }
                else if (command == "add")
                {

                    if (args.Length >= 3)
                    {
                        int id = int.Parse(Console.ReadLine());
                        String name = args[2];
                        fi.AddStudent(id, name);
                        fi.Save();
                    }
                    else
                    {
                        PrintUsage();
                        return;
                    } // end if

                }
                else if (command == "remove")
                {

                    if (args.Length >= 2)
                    {
                        String name = args[1];
                        fi.RemoveStudent(name);
                        fi.Save();
                    }
                    else
                    {
                        PrintUsage();
                        return;
                    } // end if

                }
                else
                {
                    Console.WriteLine("Command not found: " + command);
                    PrintUsage();
                } // end if


            }
            // end if
            Console.ReadLine();

        } // end public static void Main(string[] args)

        public static void PrintUsage()
        {
            Console.WriteLine("Usage: ");
            Console.WriteLine(programName + " list");
            Console.WriteLine(programName + " add <id> <name>");
            Console.WriteLine(programName + " remove <name>");
        } // end public static void Main(string[] args)
    } // end public class Program
}

