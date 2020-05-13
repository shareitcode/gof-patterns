using System;

namespace GOFPatterns.Decorator
{
    internal class BrandDecorator : Decorator
    {
        public BrandDecorator(IGraphicalComponentVehicle component) : base(component) { }

        protected void DisplayLogo()
        {
            Console.WriteLine("Logo de la marque");
        }

        public override void Display()
        {
            base.Display();
            this.DisplayLogo();
        }
    }
}