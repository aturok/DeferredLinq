using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferredLinq
{
    class StatefulPersonParser
    {
        public List<Person> People { get; private set; }

        public Person Parse(string personString)
        {
            var parts = personString.Split();

            Person person = null;
            if (parts.Count() == 2)
            {
                person = new Person() { Firstname = parts[0], Middlename = "", Lastname = parts[1] };
            }
            else if (parts.Count() == 3)
            {
                person = new Person() { Firstname = parts[0], Middlename = parts[1], Lastname = parts[2] };
            }
            else
            {
                throw new ArgumentException("Bad person string.");
            }

            People.Add(person);
            return person;
        }

        public StatefulPersonParser()
        {
            People = new List<Person>();
        }
    }
}
