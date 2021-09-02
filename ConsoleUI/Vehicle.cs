using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Year = "Unlisted";
        public string Make = "Generic";
        public string Model = "Generic";

        public abstract void VehicleStats();

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"You took the {Model} out for a virtual drive. Pretty nice! Maybe next time you'll do it outside a simulation.");
        }

    }
}
