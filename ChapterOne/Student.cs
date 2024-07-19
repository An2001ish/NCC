
using System;
using System.IO;

namespace lab1
{
    public class Student
    {
        private string name, ID, faculty;

        public void GetData()
        {
            Console.WriteLine("Enter student name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter ID: ");
            ID = Console.ReadLine();

            Console.WriteLine("Enter faculty: ");
            faculty = Console.ReadLine();
        }

        public void Write()
        {
            // Use StreamWriter to write all data at once
            using (StreamWriter writer = new StreamWriter("StudentsData.txt"))
            {
                writer.WriteLine(name);
                writer.WriteLine(ID);
                writer.WriteLine(faculty);
            }

            Console.WriteLine("Successfully written to file");
        }

        public void Read()
        {
            if (File.Exists("StudentsData.txt"))
            {
                string fileContents = File.ReadAllText("StudentsData.txt");

                Console.WriteLine("\nContents of the file:");
                Console.WriteLine(fileContents);
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

        public void DisplayFileContents()
        {
            if (File.Exists("StudentsData.txt"))
            {
                string[] lines = File.ReadAllLines("StudentsData.txt");

                Console.WriteLine("\nContents of the file:");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}







