namespace CarRentalMVC.Models.Entity
{
    internal class Product : Car
    {
        int Id { get; set; }
        int YearProduction { get; set; }
        int RegistrNumber { get; set; }
    }
}