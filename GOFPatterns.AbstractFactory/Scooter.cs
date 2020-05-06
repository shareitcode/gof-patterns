namespace GOFPatterns.AbstractFactory
{
    internal abstract class Scooter
    {
        protected string Type;
        protected string Color;
        protected int Power;

        protected internal Scooter(string type, string color, int power)
        {
            Type = type;
            Color = color;
            Power = power;
        }

        internal abstract void AfficheCharacteristics();
    }
}