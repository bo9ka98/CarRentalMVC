using System;
using System.Collections.Generic;

namespace CarRentalMVC.Models.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DataFinish { get; set; }
        public string Remarks { get; set; }

        public List<Product> CarId { get; set; }

    }
}