namespace CarRentalMVC.Models.Entity
{
    public class Product : Car
    {
        public int Id { get; set; }
        public int YearProduction { get; set; }
        public int RegistrNumber { get; set; }
    }
}