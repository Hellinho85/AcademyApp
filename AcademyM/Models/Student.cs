using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student : Person
    {
        public Subject CorrectSubject { get; set; }
        Dictionary<Subject, int> SubjectsGrades { get; set; }

        

        public Student(string firstName, string lastName, Role role, string userName, string password) : base (firstName, lastName, Role.Student, userName, password) 
        {

        }

        public void EnrollStudent (Subject subject)
        {
            this.CorrectSubject = subject;
        }




    }
}
