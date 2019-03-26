using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }


       public Person (string firstName, string lastName, Role role, string userName, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Role = Role;
            this.UserName = userName;
            this.Password = password;
        }


    }
}
