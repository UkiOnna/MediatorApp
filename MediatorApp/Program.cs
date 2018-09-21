using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Realtor realtor = new Realtor();
            Colleague renter = new Renter(realtor);
            Colleague owner = new Owner(realtor);

            realtor.Owner = owner;
            realtor.Renter = renter;

            renter.Send("Мне нужна съемная квартира,можно прийти посмотреть");
            owner.Send("Я подготовил квартиру можете приходить посмотреть");


            Console.Read();
        }
    }
}
