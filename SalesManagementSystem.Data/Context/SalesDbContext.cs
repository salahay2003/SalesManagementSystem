using Microsoft.EntityFrameworkCore;
using SalesManagementSystem.Data.Models;
namespace SalesManagementSystem.Data.Context
{
    public class SalesDbCOntext : DbContext
    {
        public SalesDbCOntext() : base() { }
            
        public SalesDbCOntext(DbContextOptions<SalesDbCOntext> options) : base(options) {  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=SalesDatabase;Integrated Security=True;Encrypt=False";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SalesDbCOntext).Assembly);

            modelBuilder.Entity<ProductLine>().HasData(
                new ProductLine { Id = 1, DescInText = "Classic Cars", DescInHTML = "Classic Cars Collection", Image = "classic.jpg" },
                new ProductLine { Id = 2, DescInText = "Motorcycles", DescInHTML = "Motorcycles Collection", Image = "motorcycles.jpg" },
                new ProductLine { Id = 3, DescInText = "Trucks", DescInHTML = "Trucks Collection", Image = "trucks.jpg" }
            );

            modelBuilder.Entity<Office>().HasData(
                new Office { Code = 1, City = "New York", Phone = "111111", Address1 = "5th Ave", State = "NY", Country = "USA", PostalCode = 10001, Territory = "NA" },
                new Office { Code = 2, City = "Los Angeles", Phone = "222222", Address1 = "Sunset Blvd", State = "CA", Country = "USA", PostalCode = 90001, Territory = "NA" },
                new Office { Code = 3, City = "Paris", Phone = "333333", Address1 = "Champs Elysees", State = "Paris", Country = "France", PostalCode = 75000, Territory = "EU" },
                new Office { Code = 4, City = "Berlin", Phone = "444444", Address1 = "Alexanderplatz", State = "Berlin", Country = "Germany", PostalCode = 10115, Territory = "EU" },
                new Office { Code = 5, City = "Tokyo", Phone = "555555", Address1 = "Shibuya", State = "Tokyo", Country = "Japan", PostalCode = 150000, Territory = "APAC" }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, OfficeCode = 1, LastName = "Smith", FirstName = "John", Extension = "101", Email = "john@company.com", JobTitle = "CEO" },
                new Employee { Id = 2, OfficeCode = 1, LastName = "Brown", FirstName = "David", Extension = "102", Email = "david@company.com", JobTitle = "Sales Manager" },
                new Employee { Id = 3, OfficeCode = 2, LastName = "Johnson", FirstName = "Emma", Extension = "201", Email = "emma@company.com", JobTitle = "Sales Rep" },
                new Employee { Id = 4, OfficeCode = 3, LastName = "Martin", FirstName = "Claire", Extension = "301", Email = "claire@company.com", JobTitle = "Sales Rep" },
                new Employee { Id = 5, OfficeCode = 4, LastName = "Schmidt", FirstName = "Lukas", Extension = "401", Email = "lukas@company.com", JobTitle = "Sales Rep" },
                new Employee { Id = 6, OfficeCode = 5, LastName = "Tanaka", FirstName = "Hiro", Extension = "501", Email = "hiro@company.com", JobTitle = "Sales Rep" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Code = 1, ProductLineId  = 1, Name = "1969 Ford Mustang", Scale = 1, Vendor = "AutoArt", PdtDescription = "Classic Mustang", QtyInStock = 50, BuyPrice = 20000, MSRP = "25000" },
                new Product { Code = 2, ProductLineId = 1, Name = "1957 Chevy Bel Air", Scale = 1, Vendor = "AutoArt", PdtDescription = "Vintage Chevy", QtyInStock = 40, BuyPrice = 18000, MSRP = "23000" },
                new Product { Code = 3, ProductLineId = 1, Name = "1970 Dodge Charger", Scale = 1, Vendor = "Highway66", PdtDescription = "Muscle car", QtyInStock = 30, BuyPrice = 22000, MSRP = "27000" },
                new Product { Code = 4, ProductLineId = 1, Name = "1965 Corvette", Scale = 1, Vendor = "Highway66", PdtDescription = "Classic Corvette", QtyInStock = 35, BuyPrice = 21000, MSRP = "26000" },
                new Product { Code = 5, ProductLineId = 1, Name = "1967 Camaro", Scale = 1, Vendor = "AutoArt", PdtDescription = "Camaro SS", QtyInStock = 25, BuyPrice = 19500, MSRP = "24000" },

                new Product { Code = 6, ProductLineId = 2, Name = "Harley Davidson", Scale = 1, Vendor = "MotoWorld", PdtDescription = "Cruiser bike", QtyInStock = 60, BuyPrice = 15000, MSRP = "19000" },
                new Product { Code = 7, ProductLineId = 2, Name = "Yamaha R1", Scale = 1, Vendor = "MotoWorld", PdtDescription = "Sport bike", QtyInStock = 45, BuyPrice = 14000, MSRP = "18000" },
                new Product { Code = 8, ProductLineId = 2, Name = "Kawasaki Ninja", Scale = 1, Vendor = "SpeedX", PdtDescription = "Racing bike", QtyInStock = 55, BuyPrice = 13500, MSRP = "17500" },
                new Product { Code = 9, ProductLineId = 2, Name = "Ducati Monster", Scale = 1, Vendor = "SpeedX", PdtDescription = "Italian bike", QtyInStock = 20, BuyPrice = 17000, MSRP = "21000" },
                new Product { Code = 10, ProductLineId = 2, Name = "BMW GS", Scale = 1, Vendor = "MotoWorld", PdtDescription = "Adventure bike", QtyInStock = 30, BuyPrice = 16000, MSRP = "20000" },

                new Product { Code = 11, ProductLineId = 3, Name = "Ford F150", Scale = 1, Vendor = "TruckPro", PdtDescription = "Pickup truck", QtyInStock = 70, BuyPrice = 30000, MSRP = "36000" },
                new Product { Code = 12, ProductLineId = 3, Name = "RAM 1500", Scale = 1, Vendor = "TruckPro", PdtDescription = "Heavy duty truck", QtyInStock = 65, BuyPrice = 32000, MSRP = "38000" },
                new Product { Code = 13, ProductLineId = 3, Name = "Toyota Tundra", Scale = 1, Vendor = "TruckPro", PdtDescription = "Reliable truck", QtyInStock = 50, BuyPrice = 29000, MSRP = "35000" },
                new Product { Code = 14, ProductLineId = 3, Name = "Chevy Silverado", Scale = 1, Vendor = "TruckPro", PdtDescription = "Work truck", QtyInStock = 45, BuyPrice = 31000, MSRP = "37000" },
                new Product { Code = 15, ProductLineId = 3, Name = "Nissan Titan", Scale = 1, Vendor = "TruckPro", PdtDescription = "Strong truck", QtyInStock = 35, BuyPrice = 28000, MSRP = "34000" }
            );
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, SalesRepNum = 3, Name = "AutoWorld", LastName = "Lee", FirstName = "Kevin", Phone = "1111", Address1 = "Street 1", City = "NY", State = "NY", PostalCode = 10001, Country = "USA", CreditLimit = 50000 },
                new Customer { Id = 2, SalesRepNum = 3, Name = "SpeedCars", LastName = "Kim", FirstName = "Alex", Phone = "2222", Address1 = "Street 2", City = "LA", State = "CA", PostalCode = 90001, Country = "USA", CreditLimit = 60000 },
                new Customer { Id = 3, SalesRepNum = 4, Name = "EuroMotors", LastName = "Dubois", FirstName = "Jean", Phone = "3333", Address1 = "Street 3", City = "Paris", State = "Paris", PostalCode = 75000, Country = "France", CreditLimit = 70000 },
                new Customer { Id = 4, SalesRepNum = 4, Name = "BerlinCars", LastName = "Schulz", FirstName = "Max", Phone = "4444", Address1 = "Street 4", City = "Berlin", State = "Berlin", PostalCode = 10115, Country = "Germany", CreditLimit = 55000 },
                new Customer { Id = 5, SalesRepNum = 5, Name = "TokyoMotors", LastName = "Sato", FirstName = "Ken", Phone = "5555", Address1 = "Street 5", City = "Tokyo", State = "Tokyo", PostalCode = 150000, Country = "Japan", CreditLimit = 80000 },
                new Customer { Id = 6, SalesRepNum = 5, Name = "TruckHub", LastName = "Miller", FirstName = "Chris", Phone = "6666", Address1 = "Street 6", City = "NY", State = "NY", PostalCode = 10002, Country = "USA", CreditLimit = 45000 },
                new Customer { Id = 7, SalesRepNum = 6, Name = "MotoX", LastName = "Tan", FirstName = "Li", Phone = "7777", Address1 = "Street 7", City = "Tokyo", State = "Tokyo", PostalCode = 150001, Country = "Japan", CreditLimit = 62000 },
                new Customer { Id = 8, SalesRepNum = 6, Name = "ClassicRide", LastName = "White", FirstName = "Sam", Phone = "8888", Address1 = "Street 8", City = "LA", State = "CA", PostalCode = 90002, Country = "USA", CreditLimit = 48000 },
                new Customer { Id = 9, SalesRepNum = 3, Name = "FastLane", LastName = "Lopez", FirstName = "Carlos", Phone = "9999", Address1 = "Street 9", City = "NY", State = "NY", PostalCode = 10003, Country = "USA", CreditLimit = 53000 },
                new Customer { Id = 10, SalesRepNum = 4, Name = "PrimeAuto", LastName = "Garcia", FirstName = "Luis", Phone = "1010", Address1 = "Street 10", City = "Paris", State = "Paris", PostalCode = 75001, Country = "France", CreditLimit = 67000 }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, CustomerID = 1, OrderDate = new DateTime(2025, 1, 1), RequireDate = new DateTime(2025, 1, 10), ShippedDate = new DateTime(2025, 1, 5), Status = 1, Comments = "Delivered" },
                new Order { Id = 2, CustomerID = 2, OrderDate = new DateTime(2025, 1, 3), RequireDate = new DateTime(2025, 1, 12), ShippedDate = new DateTime(2025, 1, 7), Status = 1, Comments = "Delivered" },
                new Order { Id = 3, CustomerID = 3, OrderDate = new DateTime(2025, 1, 5), RequireDate = new DateTime(2025, 1, 15), ShippedDate = new DateTime(2025, 1, 10), Status = 1, Comments = "Delivered" },
                new Order { Id = 4, CustomerID = 4, OrderDate = new DateTime(2025, 1, 6), RequireDate = new DateTime(2025, 1, 16), ShippedDate = new DateTime(2025, 1, 11), Status = 1, Comments = "Delivered" },
                new Order { Id = 5, CustomerID = 5, OrderDate = new DateTime(2025, 1, 8), RequireDate = new DateTime(2025, 1, 18), ShippedDate = new DateTime(2025, 1, 14), Status = 1, Comments = "Delivered" },
                new Order { Id = 6, CustomerID = 6, OrderDate = new DateTime(2025, 1, 10), RequireDate = new DateTime(2025, 1, 20), ShippedDate = new DateTime(2025, 1, 15), Status = 1, Comments = "Delivered" },
                new Order { Id = 7, CustomerID = 7, OrderDate = new DateTime(2025, 1, 12), RequireDate = new DateTime(2025, 1, 22), ShippedDate = new DateTime(2025, 1, 17), Status = 1, Comments = "Delivered" },
                new Order { Id = 8, CustomerID = 8, OrderDate = new DateTime(2025, 1, 14), RequireDate = new DateTime(2025, 1, 24), ShippedDate = new DateTime(2025, 1, 19), Status = 1, Comments = "Delivered" },
                new Order { Id = 9, CustomerID = 9, OrderDate = new DateTime(2025, 1, 16), RequireDate = new DateTime(2025, 1, 26), ShippedDate = new DateTime(2025, 1, 21), Status = 1, Comments = "Delivered" },
                new Order { Id = 10, CustomerID = 10, OrderDate = new DateTime(2025, 1, 18), RequireDate = new DateTime(2025, 1, 28), ShippedDate = new DateTime(2025, 1, 23), Status = 1, Comments = "Delivered" },
                new Order { Id = 11, CustomerID = 1, OrderDate = new DateTime(2025, 2, 1), RequireDate = new DateTime(2025, 2, 10), ShippedDate = new DateTime(2025, 2, 5), Status = 1, Comments = "Delivered" },
                new Order { Id = 12, CustomerID = 2, OrderDate = new DateTime(2025, 2, 3), RequireDate = new DateTime(2025, 2, 12), ShippedDate = new DateTime(2025, 2, 7), Status = 1, Comments = "Delivered" },
                new Order { Id = 13, CustomerID = 3, OrderDate = new DateTime(2025, 2, 5), RequireDate = new DateTime(2025, 2, 15), ShippedDate = new DateTime(2025, 2, 10), Status = 1, Comments = "Delivered" },
                new Order { Id = 14, CustomerID = 4, OrderDate = new DateTime(2025, 2, 6), RequireDate = new DateTime(2025, 2, 16), ShippedDate = new DateTime(2025, 2, 11), Status = 1, Comments = "Delivered" },
                new Order { Id = 15, CustomerID = 5, OrderDate = new DateTime(2025, 2, 8), RequireDate = new DateTime(2025, 2, 18), ShippedDate = new DateTime(2025, 2, 14), Status = 1, Comments = "Delivered" }
            );

            modelBuilder.Entity<Order_Product>().HasData(

                // Order 1
                new Order_Product { Id = 1, OrderId = 1, ProductCode = 1, Qty = 1, PriceEach = 25000 },
                new Order_Product { Id = 2, OrderId = 1, ProductCode = 6, Qty = 2, PriceEach = 19000 },

                // Order 2
                new Order_Product { Id = 3, OrderId = 2, ProductCode = 2, Qty = 1, PriceEach = 23000 },
                new Order_Product { Id = 4, OrderId = 2, ProductCode = 7, Qty = 1, PriceEach = 18000 },

                // Order 3
                new Order_Product { Id = 5, OrderId = 3, ProductCode = 3, Qty = 1, PriceEach = 27000 },
                new Order_Product { Id = 6, OrderId = 3, ProductCode = 11, Qty = 1, PriceEach = 36000 },

                // Order 4
                new Order_Product { Id = 7, OrderId = 4, ProductCode = 4, Qty = 1, PriceEach = 26000 },
                new Order_Product { Id = 8, OrderId = 4, ProductCode = 8, Qty = 2, PriceEach = 17500 },

                // Order 5
                new Order_Product { Id = 9, OrderId = 5, ProductCode = 5, Qty = 1, PriceEach = 24000 },
                new Order_Product { Id = 10, OrderId = 5, ProductCode = 9, Qty = 1, PriceEach = 21000 },

                // Order 6
                new Order_Product { Id = 11, OrderId = 6, ProductCode = 6, Qty = 1, PriceEach = 19000 },
                new Order_Product { Id = 12, OrderId = 6, ProductCode = 12, Qty = 1, PriceEach = 38000 },

                // Order 7
                new Order_Product { Id = 13, OrderId = 7, ProductCode = 7, Qty = 1, PriceEach = 18000 },
                new Order_Product { Id = 14, OrderId = 7, ProductCode = 13, Qty = 1, PriceEach = 35000 },

                // Order 8
                new Order_Product { Id = 15, OrderId = 8, ProductCode = 8, Qty = 1, PriceEach = 17500 },
                new Order_Product { Id = 16, OrderId = 8, ProductCode = 14, Qty = 1, PriceEach = 37000 },

                // Order 9
                new Order_Product { Id = 17, OrderId = 9, ProductCode = 9, Qty = 1, PriceEach = 21000 },
                new Order_Product { Id = 18, OrderId = 9, ProductCode = 15, Qty = 1, PriceEach = 34000 },

                // Order 10
                new Order_Product { Id = 19, OrderId = 10, ProductCode = 10, Qty = 1, PriceEach = 20000 },
                new Order_Product { Id = 20, OrderId = 10, ProductCode = 1, Qty = 1, PriceEach = 25000 }
            );
        }
        public virtual DbSet<Customer> Customers{ get; set; } 
        public virtual DbSet<Employee> Employees{ get; set;} 
        public virtual DbSet<Office> Offices{ get; set;} 
        public virtual DbSet<Order> Orders{ get; set;} 
        public virtual DbSet<Order_Product> Order_Products{ get; set;} 
        public virtual DbSet<Payment> Payments{ get; set;} 
        public virtual DbSet<Product> Products{ get; set;} 
        public virtual DbSet<ProductLine> ProductLines{ get; set;}
    }
}
