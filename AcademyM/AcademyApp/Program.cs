using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Subject> subjects = new List<Subject>();
            subjects.Add(new Subject("C# Advanced"));
            subjects.Add(new Subject("C# Basic"));
            subjects.Add(new Subject("Java Script Advanced"));
            subjects.Add(new Subject("Java Script Basic"));
            subjects.Add(new Subject("HTML5"));
            subjects.Add(new Subject("CSS3"));


            List<Person> User = new List<Person>();
            new Admin("Gjorgji", "Kongulovski", Role.Admin, "Hellihno", "1234");
            new Trainer("Kristijan", "Kitevski", Role.Trainer, "Kitevac", "5678");
            new Student("Nikola", "Tabakovski", Role.Student, "Hellihno", "9001");

            #region Login

            

            














            #endregion



        }
    }
}
