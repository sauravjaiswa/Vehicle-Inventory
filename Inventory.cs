using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Inventory
{
    public class Inventory
    {
        private readonly IList<IVehicle> _vehicles;

        public Inventory()
        {
            _vehicles = new List<IVehicle>();
        }

        private int GetAge(int year)
        {
            return (DateTime.Now.Year - year);
        }

        private void Display(IVehicle vehicle)
        {
            Console.WriteLine($"Owner Name - {vehicle.Owner.Name}" +
                    $"\nAddress - {vehicle.Owner.Address}" +
                    $"\nModel - {vehicle.Model}" +
                    $"\nYear - {vehicle.Year}" +
                    $"\nPurchase Value - Rs {vehicle.PurchaseValue}" +
                    $"\nDistance - {vehicle.Distance} km" +
                    $"\nSale Price - Rs {vehicle.SalePrice}");
        }

        public void Add(IVehicle vehicle)
        {
            if (GetAge(vehicle.Year) > 10)
            {
                return;
            }
            _vehicles.Add(vehicle);
        }

        public void DisplayAll()
        {
            Console.WriteLine("All Vehicles ->");
            foreach (IVehicle vehicle in _vehicles)
            {
                Display(vehicle);
                Console.WriteLine("------------------------------------------");
            }
        }

        public void AgeSearch(int years)
        {
            var query = _vehicles.Where(v => (GetAge(v.Year) == years));
            
            Console.WriteLine($"All Vehicles of {years} years->");
            foreach (IVehicle vehicle in query)
            {
                Display(vehicle);
                Console.WriteLine("------------------------------------------");
            }
        }

        public void SalesPriceSearch(double price)
        {
            var query = _vehicles.Where(v => (v.SalePrice == price));

            Console.WriteLine($"All Vehicles of Rs {price}->");
            foreach (IVehicle vehicle in query)
            {
                Display(vehicle);
                Console.WriteLine("------------------------------------------");
            }
        }
    }
}