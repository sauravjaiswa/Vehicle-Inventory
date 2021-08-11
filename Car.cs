namespace Vehicle_Inventory
{
    public class Car : IVehicle
    {
        public Owner Owner { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double PurchaseValue { get; set; }
        public double Distance { get; set; }
        public double SalePrice
        {
            get
            {
                double sp = 0.0;
                if (Distance <= 25000)
                    sp = 0.85 * PurchaseValue;
                else if (Distance <= 50000)
                    sp = 0.75 * PurchaseValue;
                else if (Distance <= 75000)
                    sp = 0.65 * PurchaseValue;
                else if (Distance <= 100000)
                    sp = 0.45 * PurchaseValue;
                else
                    sp = 0.25 * PurchaseValue;

                return sp;
            }
        }
    }
}
