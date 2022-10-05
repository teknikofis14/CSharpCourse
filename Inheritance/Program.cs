using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer {FirstName="Nedim" },
                new Student {FirstName="Emre" },
                new Person {FirstName="Salih" }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }


            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //Customer class ının bir Person olduğunu söyledik.
    //Customer class ı Person class ının child ı oluyor.
    //Bir kişinin bir babası olabilir. O yüzden Customer: Person, Person2 gibi bird kullanım söz konusu değildir.
    class Customer : Person
    {
        public string City { get; set; }
    }

    //Stident class ı Person class ının child ı oluyor.
    class Student : Person
    {
        public string Department { get; set; }
    }
}
