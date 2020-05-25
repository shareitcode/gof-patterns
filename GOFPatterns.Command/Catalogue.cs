using System.Collections.Generic;
using System.Linq;

namespace GOFPatterns.Command
{
    internal class Catalogue
    {
        private readonly List<Vehicle> _vehicles = new List<Vehicle>();
        private readonly List<CommandSellOut> _commands = new List<CommandSellOut>();

        internal void StartCommandSellOut(CommandSellOut command)
        {
            this._commands.Add(command);
            command.SellOut(this._vehicles);
        }

        internal void CancelCommandSellOut(int index)
        {
            this._commands.ElementAt(index).Cancel();
        }

        internal void RollbackCommandSellOut(int index)
        {
            this._commands.ElementAt(index).Rollback();
        }

        internal void Add(Vehicle vehicle)
        {
            this._vehicles.Add(vehicle);
        }

        internal void Display()
        {
            this._vehicles.ForEach(vehicle =>
            {
                vehicle.Display();
            });
        }
    }
}