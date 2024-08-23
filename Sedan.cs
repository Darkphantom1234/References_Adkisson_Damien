using System;
using System.Collections.Generic;
using System.Text;

namespace References_Adkisson_Damien
{
    class Sedan : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LincensePlate { get; private set; }
        public object LicensePlate { get; private set; }

        public Sedan(double Speed )
        {
            Wheels = 4;
            Speed = Speed;
            LincensePlate = "GCTC-06";
        }

        public void stringify()
        {
            Console.WriteLine($"The Sedan is taveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
        }
        
        public void Increasespeed()
        {
            Speed += 5;
        }

        public void Decreasespeed()
        {
            Speed -= 5;
        }
    }
}
