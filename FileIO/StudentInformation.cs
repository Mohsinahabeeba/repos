using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIO
{
    public class StudentsInformation
    {
        private static StudentsInformation studentsInformation;

        private Dictionary<string, Info> studentsDictionary;
        private BinaryFormatter formatter;

        private const string DATA_FILENAME = @"D:\readwrite\Demo.txt";

        public static StudentsInformation Instance()
        {
            if (studentsInformation == null)
            {
                studentsInformation = new StudentsInformation();
            } // end if

            return studentsInformation;
        } // end public static FriendsInformation Instance()

        private StudentsInformation()
        {
            // Create a Dictionary to store friends at runtime
            this.studentsDictionary = new Dictionary<string, Info>();
            this.formatter = new BinaryFormatter();
        } // end private FriendsInformation()

        public void AddStudent(int id, string name)
        {
            // If we already had added a friend with this name
            if (this.studentsDictionary.ContainsKey(name))
            {
                Console.WriteLine("You had already added " + name + " before.");
            }
            // Else if we do not have this friend details 
            // in our dictionary
            else
            {
                Console.WriteLine("adding a new item");
                Console.WriteLine("enter the student name");
                name = Console.ReadLine();

                Console.WriteLine("enter the id");
                id = Convert.ToInt32(Console.ReadLine());

                // Add him in the dictionary
                this.studentsDictionary.Add(name, new Info(id, name));
                Console.WriteLine("student added successfully.");
            } // end if
        } // end public bool AddFriend(string name, string email)

        public void RemoveStudent(string studentName)
        {
            // If we do not have a friend with this name
            if (!this.studentsDictionary.ContainsKey(studentName))
            {
                Console.WriteLine(studentName + " had not been added before.");
            }
            // Else if we have a friend with this name
            else
            {
                if (this.studentsDictionary.Remove(studentName))
                {
                    Console.WriteLine(studentName + " had been removed successfully.");
                }
                else
                {
                    Console.WriteLine("Unable to remove " + studentName);
                } // end if
            } // end if
        } // end public bool RemoveFriend(string name)

        public void Save()
        {
            // Gain code access to the file that we are going
            // to write to
            try
            {
                // Create a FileStream that will write data to file.
                FileStream writerFileStream =
                    new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write);
                // Save our dictionary of friends to file
                this.formatter.Serialize(writerFileStream, this.studentsDictionary);

                // Close the writerFileStream when we are done.
                writerFileStream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to save our friends' information");
            } // end try-catch
        } // end public bool Load()

        public void Load()
        {

            // Check if we had previously Save information of our friends
            // previously
            if (File.Exists(DATA_FILENAME))
            {

                try
                {
                    // Create a FileStream will gain read access to the 
                    // data file.
                    FileStream readerFileStream = new FileStream(DATA_FILENAME,
                        FileMode.Open, FileAccess.Read);
                    // Reconstruct information of our friends from file.
                    this.studentsDictionary = (Dictionary<String, Info>)
                        this.formatter.Deserialize(readerFileStream);
                    // Close the readerFileStream when we are done
                    readerFileStream.Close();

                }
                catch (Exception)
                {
                    Console.WriteLine("There seems to be a file that contains " +
                        "friends information but somehow there is a problem " +
                        "with reading it.");
                } // end try-catch

            } // end if

        } // end public bool Load()

        public void Print()
        {
            // If we have saved information about friends
            if (this.studentsDictionary.Count > 0)
            {
                Console.WriteLine("id, name");
                foreach (Info inf in this.studentsDictionary.Values)
                {
                    Console.WriteLine(inf.Identity + ", " + inf.Name);
                } // end foreach
            }
            else
            {
                Console.WriteLine("There are no saved information about your friends");
            } // end if
        } // end public void Print()

    } // end public class FriendsInformation

}

