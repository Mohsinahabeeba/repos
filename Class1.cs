using System;
using System.IO;
using System.Collections.Generic;
public class Details
{
    public int studentID;
    public string studentName;
    public Details(int studentID, string studentName)
    {
        this.studentID = studentID;
        this.studentName = studentName;
    }
}

public class Class1
{
	
        public static void Main()
        {
            string filePath=@"D:\readwrite\Demo.txt";
        List<string> lines = File.ReadAllLines(filepath).ToList();
        foreach(string line in lines )
        {
            Console.WriteLine(line);
        }
        lines.Add("mohsina habeeba is ");
        File.WriteAllLines(filePath, lines);
        }
	
}
