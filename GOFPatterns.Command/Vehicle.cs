using System;

namespace GOFPatterns.Command
{
    internal class Vehicle
    {
        private readonly string _name;
        private readonly long _dateStockEntry;
        private double _sellPrice;

        internal Vehicle(string name, long dateStockEntry, double sellPrice)
        {
            this._name = name;
            this._dateStockEntry = dateStockEntry;
            this._sellPrice = sellPrice;
        }

        internal long GetStockDuration(long today)
        {
            return today - this._dateStockEntry;
        }

        internal void UpdatePrice(double coefficient)
        {
            this._sellPrice = 0.01 * Math.Round(coefficient * this._sellPrice * 100);
        }

        internal void Display()
        {
            Console.WriteLine($"{this._name} prix : {this._sellPrice} date entrée Stock {this._dateStockEntry}.");
        }
    }
}