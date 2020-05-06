using System;

namespace GOFPatterns.AbstractFactory
{
    internal class ScooterElectric : Scooter
    {
        internal ScooterElectric(string type, string color, int power) : base(type, color, power) { }

        internal override void AfficheCharacteristics()
        {
            Console.WriteLine($"Scooter électrique de modèle : {Type} de couleur : {Color} de puissance : {Power}");
        }
    }
}