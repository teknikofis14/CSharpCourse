using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //InterfacesIntro();

            //interface kendi başına new yapılamaz.
            //IPerson person = new IPerson();   //Hata verir.


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomarDal());




            //Konsolun açık kalmasını sağlar.
            Console.ReadLine();
        }


        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();

            //Kısa yazım
            //manager.Add(new Customer { Id = 1, FirstName = "Nedim", LastName = "AKCA", Address = "Karabük" });


            //Uzun yazım
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Nedim",
                LastName = "AKCA",
                Address = "Karabük"
            };
            manager.Add(customer);





            Student student = new Student
            {
                Id = 1,
                FirstName = "Emre",
                LastName = "AKCA",
                Department = "Computer Education and Instructional Technology"
            };

            manager.Add(student);
        }

        //interface soyut nesnedir. class ise somut nesnedir.
        //soyut nesneler tek başına bir anlam ifade etmez.
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }


        //Customer:IPerson eklediğimizde IPerson'da tanımlanan her şeyi class içerisinde görebiliriz.
        //IPerson interface eklenen her öğeyi public olarak class içerisine eklememiz gerekiyor
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            //Müşterinin adresini interface harici olarak class içerisine ekledik.
            public string Address { get; set; }
        }


        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            //Öğrencinin bölümünü interface harici olarak class içerisine ekledik.
            public string Department { get; set; }
        }


        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            //Öğrencinin bölümünü interface harici olarak class içerisine ekledik.
            public string Department { get; set; }
        }


        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
