using System;

namespace Vehicle_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            string ch;
            int age;
            double sp;

            do
            {
                Console.WriteLine("1) Adding a Vehicle");
                Console.WriteLine("2) Displaying all vehicles");
                Console.WriteLine("3) Search vehicle based on Age");
                Console.WriteLine("4) Search vehicle based on Sale Price");
                Console.WriteLine("5) Exit");
                Console.WriteLine("Enter a choice:");
                ch = Console.ReadLine();

                switch (ch)
                {
                    case "1":
                        inventory.Add(new Car() { Owner = new Owner { Name = "A", Address = "XYZ" }, Model = "SUV908", Year = 2015, PurchaseValue = 5264921, Distance = 10000 });
                        inventory.Add(new Bike() { Owner = new Owner { Name = "B", Address = "HDJS" }, Model = "XYW765", Year = 2012, PurchaseValue = 45649, Distance = 5000 });
                        inventory.Add(new Bike() { Owner = new Owner { Name = "C", Address = "DHS" }, Model = "HB165", Year = 2005, PurchaseValue = 5264921, Distance = 19000 });
                        inventory.Add(new Car() { Owner = new Owner { Name = "D", Address = "CCU" }, Model = "UYR657", Year = 2013, PurchaseValue = 5264921, Distance = 51000 });
                        break;
                    case "2":
                        inventory.DisplayAll();
                        break;
                    case "3":
                        Console.WriteLine("Enter age to be searched for : ");
                        age = int.Parse(Console.ReadLine());
                        inventory.AgeSearch(age);
                        break;
                    case "4":
                        Console.WriteLine("Enter sales price to be searched for : ");
                        sp = double.Parse(Console.ReadLine());
                        inventory.SalesPriceSearch(sp);
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Try again...");
                        break;
                }
            } while (true);
        }
    }
}
