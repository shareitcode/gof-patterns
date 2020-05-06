using System;

namespace GOFPatterns.AbstractFactory
{
    internal class ScooterFuel : Scooter
    {
        internal ScooterFuel(string type, string color, int power) : base(type, color, power) { }

        internal override void AfficheCharacteristics()
        {
            Console.WriteLine($"Scooter à essence de modèle : {Type} de couleur : {Color} de puissance : {Power}");
        }
    }
}