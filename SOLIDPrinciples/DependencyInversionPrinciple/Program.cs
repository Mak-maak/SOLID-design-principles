using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChilderenOf(string name);
    }

    public class Program
    {
        public Program(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChilderenOf("John"))
                Console.WriteLine($"John has a child called {p.Name}");
        }

        static void Main(string[] args)
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Mary" };

            Relationships relations = new Relationships();
            relations.AddParentAndChild(parent, child1);
            relations.AddParentAndChild(parent, child2);

            Console.ReadKey();
        }
    }
}
