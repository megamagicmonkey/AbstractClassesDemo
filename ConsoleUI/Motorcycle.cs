using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool HasSidecar;
        public override void DriveAbstract()
        {
            Console.WriteLine($"You took the {Model} out for an abstract drive.");
            Console.WriteLine("You decided to stop at Imagination for an order of atomic theory with a side of perception of heat.");
            Console.WriteLine("You are filled with confusion.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"You took the {Model} out for a virtual drive! Gotta love that digital wind on your face!");
        }

        public override void VehicleStats()
        {
            string sidecarStatement;
            if (HasSidecar)
            {
                sidecarStatement = "is sidecar compatible";
            }
            else
            {
                sidecarStatement = "does not support sidecars";
            }

            Console.WriteLine($"This motorcycle was made by {Make} for the year {Year}. It is a model-type {Model}, which {sidecarStatement}.");
        }
    }
}
