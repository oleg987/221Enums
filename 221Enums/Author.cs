using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221Enums
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public Author(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
