using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferredLinq
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }

        public override string ToString()
        {
            return String.IsNullOrEmpty(Middlename) ?
                Firstname + " " + Lastname :
                Firstname + " " + Middlename + " " + Lastname;
        }
    }
}
