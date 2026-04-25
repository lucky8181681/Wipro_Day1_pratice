using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Csharp.Day2
{
    internal class Student
    {
        public string Name;
        public int Id;

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Id: {Id}");

        }
        public void UpdateDetails(string newName,int newId)
        {
            Name = newName;
            Id = newId;
        }
    }
}
