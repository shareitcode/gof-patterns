using System;

namespace GOFPatterns.AbstractFactory
{
    internal class Catalog
    {
        private const int NbAutos = 3;
        private const int NbScooters = 2;

        public Catalog()
        {
            IFabricVehicle fabrique;
            Automobile[] autos = new Automobile[NbAutos];
            Scooter[] scooters = new Scooter[NbScooters];

            Console.WriteLine("Voulez-vous utiliser des véhicules électriques (1) ou à essence (2) :");
            string choix = Console.ReadLine();

            if (choix == "1")
            {
                fabrique = new FabricVehicleElectric();
            }
            else
            {
                fabrique = new FabricVehicleFuel();
            }

            for (int index = 0; index < NbAutos; index++)
            {
                autos[index] = fabrique.CreateAutomobile("standard", "jaune", 6 + index, 3.2);
            }

            for (int index = 0; index < NbScooters; index++)
            {
                scooters[index] = fabrique.CreateScooter("classic", "rouge", 2 + index);
            }

            foreach (Automobile auto in autos)
            {
                auto.AfficheCharacteristics();
            }

            foreach (Scooter scooter in scooters)
            {
                scooter.AfficheCharacteristics();
            }
        }
    }
}