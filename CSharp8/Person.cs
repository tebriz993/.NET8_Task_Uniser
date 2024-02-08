using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    internal class Person
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Surname { get; set; }

        public Person(int id,string name,string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public virtual void FullInfo()
        {
            Console.WriteLine($"{Id} {Name} {Surname}"); 
        }
    }
}
