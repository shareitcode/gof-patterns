namespace GOFPatterns.Decorator
{
    internal abstract class Decorator : IGraphicalComponentVehicle
    {
        protected IGraphicalComponentVehicle Component;

        protected Decorator(IGraphicalComponentVehicle component)
        {
            this.Component = component;
        }

        public virtual void Display()
        {
            this.Component.Display();
        }
    }
}