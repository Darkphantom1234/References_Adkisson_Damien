using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace References_Adkisson_Damien
{
    class Truck : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LincensePlate { get; private set; }

        public double weight { get; }
        public object Licenseplate { get; }
        public object? LicenseNum { get; }

        public Truck(double speedparam, double weightparam, string v)
        {
            Speed = speedparam;
            weight = weightparam;
            Licenseplate = LicenseNum;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12; 
            }
        }


        public void stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {Licenseplate}!");
        }

        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
