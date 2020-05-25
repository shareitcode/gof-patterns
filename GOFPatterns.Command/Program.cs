using System;

namespace GOFPatterns.Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("VH-1", 1, 1000.0);
            Vehicle vehicle2 = new Vehicle("VH-2", 6, 2000.0);
            Vehicle vehicle3 = new Vehicle("VH-3", 2, 3000.0);

            Catalogue catalogue = new Catalogue();
            catalogue.Add(vehicle1);
            catalogue.Add(vehicle2);
            catalogue.Add(vehicle3);

            Console.WriteLine("Affichage du catalogue initial");
            catalogue.Display();

            CommandSellOut commandSellOut1 = new CommandSellOut(10, 5, 0.1);
            catalogue.StartCommandSellOut(commandSellOut1);
            Console.WriteLine("\nAffichage du catalogue après exécution de la première commande");
            catalogue.Display();

            CommandSellOut commandSellOut2 = new CommandSellOut(10, 5, 0.5);
            catalogue.StartCommandSellOut(commandSellOut2);
            Console.WriteLine("\nAffichage du catalogue après exécution de la seconde commande");
            catalogue.Display();

            catalogue.CancelCommandSellOut(1);
            Console.WriteLine("\nAffichage du catalogue après annulation de la première commande");
            catalogue.Display();

            catalogue.RollbackCommandSellOut(1);
            Console.WriteLine("\nAffichage du catalogue après rétablissement de la première commande");
            catalogue.Display();
        }
    }
}