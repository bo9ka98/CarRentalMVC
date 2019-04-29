using System;
using System.Collections.Generic;

namespace CarRentalMVC.Models.Entity
{
    public class Order
    {
        int Id { get; set; }
        int ClientId { get; set; }
        DateTime DateStart { get; set; }
        DateTime DataFinish { get; set; }
        string Remarks { get; set; }

        List<Product> CarId { get; set; }

    }
}