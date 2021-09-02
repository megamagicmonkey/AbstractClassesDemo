using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {

        public bool HasTrunk;
        public override void DriveAbstract()
        {
            Console.WriteLine($"You took the {Model} out for an abstract drive. The color of ideas and the taste of memories swirl around you.");
            Console.WriteLine("What... What just happened?");
        }

        public override void VehicleStats()
        {
            string trunkStatement;
            if (HasTrunk)
            {
                trunkStatement = "has a trunk";
            }
            else
            {
                trunkStatement = "has no trunk";
            }

            Console.WriteLine($"This car was made by {Make} for the year {Year}. It is a model-type {Model}, which {trunkStatement}.");
        }
    }
}
