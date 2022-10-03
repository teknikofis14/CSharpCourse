using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //prop yazıp iki kere Tab bastık public ... ... {get; set} otomatik ekledi. property kısaltması
        //Müşterinin özelliklerini tutmak için ekledik.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
