using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferredLinq
{
    class StatefulPersonParser
    {
        public Person Parse(string personString)
        {
            var parts = personString.Split();
            if (parts.Count() == 2)
            {
                var person = new Person() { Firstname = parts[0], Middlename = "", Lastname = parts[1] };
                return person;
            }
            else if (parts.Count() == 3)
            {
                var person = new Person() { Firstname = parts[0], Middlename = parts[1], Lastname = parts[2] };
                return person;
            }
            else
                throw new ArgumentException("Bad person string.");
        }
    }
}
