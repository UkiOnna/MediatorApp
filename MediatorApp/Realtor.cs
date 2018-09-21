using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorApp
{
    class Realtor : Mediator
    {
        public Colleague Renter { get; set; }
        public Colleague Owner { get; set; }

        public override void Send(string msg, Colleague colleague)
        {
            if (Renter == colleague)
                Owner.Notify(msg);

            else if (Owner == colleague)
                Renter.Notify(msg);
        }
    }
}
