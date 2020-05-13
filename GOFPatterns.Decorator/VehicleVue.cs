using System;

namespace GOFPatterns.Decorator
{
    internal class VehicleVue : IGraphicalComponentVehicle
    {
        public void Display()
        {
            Console.WriteLine("Affichage du véhicule");
        }
    }
}