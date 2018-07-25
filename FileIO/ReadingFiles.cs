using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class ReadingFiles
    {
        public static void ReadForFile(string direc)

        {


           // string[] filepath = Directory.GetFiles(direc,"*.txt");
            DirectoryInfo fi = new DirectoryInfo(direc);
            FileInfo[] files = fi.GetFiles("*.txt");
            foreach(FileInfo flp in files)
            {
                Console.WriteLine(flp);
                Console.WriteLine(flp.CreationTime);
                if(flp.LastWriteTime> DateTime.Now.AddMinutes(-3))
                {
                    Console.WriteLine(flp.LastWriteTime);
                }
                else
                {
                    Console.WriteLine("nothing modified");
                }
                

            }
         }

        public static void Main()
        {
            
            ReadForFile(@"D:\mohs\JSONS\FileIO\data");
            
            Console.ReadLine();
        }
    }
}

