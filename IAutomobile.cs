using System;
using System.Collections.Generic;
using System.Text;

namespace References_Adkisson_Damien
{
    interface IAutomobile
    {

       public double Speed {  get; } 

        public int Wheels { get;}

        public string LincensePlate { get; }

        public void stringify();
 
    }
}
