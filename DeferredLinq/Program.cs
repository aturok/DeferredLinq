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

            var firstnames = parsedPeople.Select(p => p.Firstname);
            var middlenames = parsedPeople.Select(p => p.Middlename);
            var lastnames = parsedPeople.Select(p => p.Lastname);

            foreach (var name in lastnames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            foreach (var name in firstnames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            foreach (var name in middlenames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            Console.WriteLine(String.Format("A total of {0} people were parsed.", parser.People.Count));

            Console.ReadLine();
        }
    }
}
