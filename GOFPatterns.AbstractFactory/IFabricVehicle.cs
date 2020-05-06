namespace GOFPatterns.AbstractFactory
{
    internal interface IFabricVehicle
    {
        Automobile CreateAutomobile(string type, string color, int power, double space);

        Scooter CreateScooter(string type, string color, int power);
    }
}