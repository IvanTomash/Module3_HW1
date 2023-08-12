using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_1
{
    /// <summary>
    /// Starter class.
    /// </summary>
    internal class App
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
        }

        /// <summary>
        /// Starts program execution.
        /// </summary>
        public void Run()
        {
            CustomCollection<Person> collection = new CustomCollection<Person>(new Person[]
            {
                new Person(4, "Andrew"),
                new Person(1, "Ivan"),
                new Person(2, "John"),
                new Person(5, "Diana"),
                new Person(3, "Kate"),
                new Person(6, "Vlad"),
                new Person(10, "Sam"),
            });
            collection.Add(new Person(8, "Ann"));
            collection.Add(new Person(7, "Max"));
            collection.Add(new Person(9, "Helen"));

            Console.WriteLine("Lenght: " + collection.Count());
            foreach (var i in collection)
            {
                Console.WriteLine(i);
            }

            collection.Sort();
            Console.WriteLine("After sorting:");
            foreach (var i in collection)
            {
                Console.WriteLine(i.ToString());
            }

            collection.SetDefaultAt(1);
            Console.WriteLine("After setting default value:");
            foreach (var i in collection)
            {
                if (i != null)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
}
