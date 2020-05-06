namespace GOFPatterns.AbstractFactory
{
    internal class FabricVehicleFuel : IFabricVehicle
    {
        public Automobile CreateAutomobile(string type, string color, int power, double space)
        {
            return new AutomobileFuel(type, color, power, space);
        }

        public Scooter CreateScooter(string type, string color, int power)
        {
            return new ScooterFuel(type, color, power);
        }
    }
}