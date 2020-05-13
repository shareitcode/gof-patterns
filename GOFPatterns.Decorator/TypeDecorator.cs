using System;

namespace GOFPatterns.Decorator
{
    internal class TypeDecorator : Decorator
    {
        public TypeDecorator(IGraphicalComponentVehicle component) : base(component) { }

        protected void DisplayTechnicalInformations()
        {
            Console.WriteLine("Informations techniques du modèle");
        }

        public override void Display()
        {
            base.Display();
            this.DisplayTechnicalInformations();
        }
    }
}