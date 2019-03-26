using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Trainer : Person
    {
        public Trainer(string firstName, string lastName, Role role, string userName, string password) : base (firstName, lastName, Role.Trainer, userName, password)
        {

        }

    }
}
