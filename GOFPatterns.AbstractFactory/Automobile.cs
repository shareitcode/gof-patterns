namespace GOFPatterns.AbstractFactory
{
    internal abstract class Automobile
    {
        protected string Type;
        protected string Color;
        protected int Power;
        protected double Space;

        internal Automobile(string type, string color, int power, double space)
        {
            this.Type = type;
            this.Color = color;
            this.Power = power;
            this.Space = space;
        }

        internal abstract void AfficheCharacteristics();
    }
}