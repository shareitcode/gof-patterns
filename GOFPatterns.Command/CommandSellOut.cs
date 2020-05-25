using System.Collections.Generic;

namespace GOFPatterns.Command
{
    internal class CommandSellOut : ICommand
    {
        private readonly List<Vehicle> _vehiclesSellOut = new List<Vehicle>();
        private readonly long _today;
        private readonly long _stockDuration;
        private readonly double _discountRate;

        internal CommandSellOut(long today, long stockDuration, double discountRate)
        {
            _today = today;
            _stockDuration = stockDuration;
            _discountRate = discountRate;
        }

        public void SellOut(List<Vehicle> vehicles)
        {
            _vehiclesSellOut.Clear();
            vehicles.ForEach(vehicle =>
            {
                if (vehicle.GetStockDuration(this._today) >= this._stockDuration)
                {
                    _vehiclesSellOut.Add(vehicle);
                }
            });
            _vehiclesSellOut.ForEach(vehicle =>
            {
                vehicle.UpdatePrice(1.0 - this._discountRate);
            });
        }

        public void Cancel()
        {
            this._vehiclesSellOut.ForEach(vehicle =>
            {
                vehicle.UpdatePrice(1.0 / (1.0 - this._discountRate));
            });
        }

        public void Rollback()
        {
            this._vehiclesSellOut.ForEach(vehicle =>
            {
                vehicle.UpdatePrice(1.0 - this._discountRate);
            });
        }
    }
}