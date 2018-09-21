﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApp
{
    class Renter : Colleague
    {
        public Renter(Mediator mediator) : base(mediator)
        {

        }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение арендатору: " + message);
        }
    }
}
