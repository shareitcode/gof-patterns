namespace GOFPatterns.AbstractFactory
{
    internal class FabricVehicleElectric : IFabricVehicle
    {
        public Automobile CreateAutomobile(string type, string color, int power, double space)
        {
            return new AutomobileElectric(type, color, power, space);
        }

        public Scooter CreateScooter(string type, string color, int power)
        {
            return new ScooterElectric(type, color, power);
        }
    }
}