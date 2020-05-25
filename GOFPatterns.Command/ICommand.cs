using System.Collections.Generic;

namespace GOFPatterns.Command
{
    internal interface ICommand
    {
        public void SellOut(List<Vehicle> vehicles);
        public void Cancel();
        public void Rollback();
    }
}