using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApp
{
    class Owner : Colleague
    {
        public Owner(Mediator mediator) : base(mediator)
        {

        }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение хозяину: " + message);
        }
    }
}
