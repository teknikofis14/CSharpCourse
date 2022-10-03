using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class oluşturulurken ilk harfi büyük yazılır. Ama onun örneği yazılırken ilk harfi küçük yazılır. CustomerManager Class, customerManager onun örneğidir.
            //Proje içerisindeki CustomerManager.cs'de sınıf yer almaktadır.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();


            //Proje içerisindeki ProductManager.cs'de sınıf yer almaktadır.
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();


            //Customer sınıfını çağırdım customer örneğine atadım ve Id, FirstName gibi değerleri atadım.
            //Customer sınıfındaki set bloğunu çalıştırır.
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Nedim";
            customer.LastName = "AKCA";
            customer.City = "Karabük";


            //Bir üstteki sınıf çağırmayla aynı işlevi görür. Parantez aç kapa yerine süslü parantez açıp değerleri atadım.
            Customer customer2 = new Customer
            {
                //Ctrl+Spacebar basınca Customer sınıfında tanımlanan değerler (Id, FirstName vb.) çıkıyor.
                Id = 2, FirstName = "Emre", LastName = "AKCA", City = "Karabük"
            };


            //customer2'nin FirstName değerini ekrana yazdırır.
            //Customer sınıfındaki get bloğunu çalıştırır.
            Console.WriteLine(customer2.FirstName);


            //Konsol ekranında bekletir.
            Console.ReadLine();
        }

    }
}
