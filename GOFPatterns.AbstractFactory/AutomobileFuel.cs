using System;

namespace GOFPatterns.AbstractFactory
{
    internal class AutomobileFuel : Automobile
    {
        internal AutomobileFuel(string type, string color, int power, double space) : base(type, color, power, space) { }

        internal override void AfficheCharacteristics()
        {
            Console.WriteLine($"Automobile à essence de modèle : {Type} de couleur : {Color} de puissance : {Power} d’espace : {Space}");
        }
    }
}