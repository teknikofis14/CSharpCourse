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


            //Konsol ekranında bekletir.
            Console.ReadLine();
        }

    }
}
