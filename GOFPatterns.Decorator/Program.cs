namespace GOFPatterns.Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            VehicleVue vehicleVue = new VehicleVue();
            TypeDecorator typeDecorator = new TypeDecorator(vehicleVue);
            BrandDecorator brandDecorator = new BrandDecorator(typeDecorator);
            brandDecorator.Display();
        }
    }
}