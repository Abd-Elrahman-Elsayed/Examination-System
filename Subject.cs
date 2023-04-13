using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sys
{
    internal class Subject
    {
        int id;
        string name;
        int marks = 100;
        static int idCounter = 1;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Marks { get => marks; set => marks = value; }

        public Subject(string name)
        {
            Id = idCounter;
            Name = name;
            idCounter++;
        }
    }
}
