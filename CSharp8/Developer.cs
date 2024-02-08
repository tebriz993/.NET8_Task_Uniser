using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    internal class Developer:Person
    {
        public string ProgrammingSkills { get; set; }

        public Developer(int Id,string Name,string Surname,string programmingSkills):base(Id,Name,Surname)
        {
            ProgrammingSkills=programmingSkills;
        }

        public override void FullInfo()
        {
            Console.WriteLine($"{Id} {Name} {Surname} {ProgrammingSkills}");
        }
    }
}
