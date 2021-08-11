namespace Vehicle_Inventory
{
    public interface IVehicle
    {
        Owner Owner { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        double PurchaseValue { get; set; }
        double Distance { get; set; }
        double SalePrice { get; }
    }
}
