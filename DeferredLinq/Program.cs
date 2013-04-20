using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferredLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string somePeople = @"Douglas R. Hofstadter,Egbert B. Gebstadter,James Gleik";

            var parser = new StatefulPersonParser();
            var parsedPeople = somePeople.Split(',').Select(_ => parser.Parse(_));
            foreach (var p in parsedPeople)
            {
                Console.WriteLine(p.Lastname + ", " + p.Firstname + " " + p.Middlename);
            }

            Console.ReadLine();
        }
    }
}
