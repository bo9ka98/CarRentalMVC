using CarRentalMVC.Models.Entity;
using System;
using System.Data.Entity;


namespace CarRentalMVC.Models.DAO
{
    public class ClientContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
    }

    public class ClientInitializerContext : DropCreateDatabaseAlways<ClientContext>
    {
        protected override void Seed(ClientContext db)
        {
            db.Clients.Add(new Client { Name = "Иван", Surname = "Иванов", DateBirth = DateTime.Now, DriverLicense = 11 });
            db.Clients.Add(new Client { Name = "Петя", Surname = "Петров", DateBirth = DateTime.Now, DriverLicense = 12 });

            base.Seed(db);
        }
    }
}