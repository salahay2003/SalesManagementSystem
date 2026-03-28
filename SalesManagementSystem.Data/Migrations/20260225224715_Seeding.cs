using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sate",
                table: "Customers",
                newName: "State");

            migrationBuilder.AlterColumn<int>(
                name: "ReportsTo",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Code", "Address1", "Address2", "City", "Country", "Phone", "PostalCode", "State", "Territory" },
                values: new object[,]
                {
                    { 1, "5th Ave", null, "New York", "USA", "111111", 10001, "NY", "NA" },
                    { 2, "Sunset Blvd", null, "Los Angeles", "USA", "222222", 90001, "CA", "NA" },
                    { 3, "Champs Elysees", null, "Paris", "France", "333333", 75000, "Paris", "EU" },
                    { 4, "Alexanderplatz", null, "Berlin", "Germany", "444444", 10115, "Berlin", "EU" },
                    { 5, "Shibuya", null, "Tokyo", "Japan", "555555", 150000, "Tokyo", "APAC" }
                });

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "Id", "DescInHTML", "DescInText", "Image" },
                values: new object[,]
                {
                    { 1, "Classic Cars Collection", "Classic Cars", "classic.jpg" },
                    { 2, "Motorcycles Collection", "Motorcycles", "motorcycles.jpg" },
                    { 3, "Trucks Collection", "Trucks", "trucks.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Extension", "FirstName", "JobTitle", "LastName", "OfficeCode", "ReportsTo" },
                values: new object[,]
                {
                    { 1, "john@company.com", "101", "John", "CEO", "Smith", 1, null },
                    { 2, "david@company.com", "102", "David", "Sales Manager", "Brown", 1, null },
                    { 3, "emma@company.com", "201", "Emma", "Sales Rep", "Johnson", 2, null },
                    { 4, "claire@company.com", "301", "Claire", "Sales Rep", "Martin", 3, null },
                    { 5, "lukas@company.com", "401", "Lukas", "Sales Rep", "Schmidt", 4, null },
                    { 6, "hiro@company.com", "501", "Hiro", "Sales Rep", "Tanaka", 5, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Code", "BuyPrice", "MSRP", "Name", "PdtDescription", "ProductLineId", "QtyInStock", "Scale", "Vendor" },
                values: new object[,]
                {
                    { 1, 20000m, "25000", "1969 Ford Mustang", "Classic Mustang", 1, 50, 1, "AutoArt" },
                    { 2, 18000m, "23000", "1957 Chevy Bel Air", "Vintage Chevy", 1, 40, 1, "AutoArt" },
                    { 3, 22000m, "27000", "1970 Dodge Charger", "Muscle car", 1, 30, 1, "Highway66" },
                    { 4, 21000m, "26000", "1965 Corvette", "Classic Corvette", 1, 35, 1, "Highway66" },
                    { 5, 19500m, "24000", "1967 Camaro", "Camaro SS", 1, 25, 1, "AutoArt" },
                    { 6, 15000m, "19000", "Harley Davidson", "Cruiser bike", 2, 60, 1, "MotoWorld" },
                    { 7, 14000m, "18000", "Yamaha R1", "Sport bike", 2, 45, 1, "MotoWorld" },
                    { 8, 13500m, "17500", "Kawasaki Ninja", "Racing bike", 2, 55, 1, "SpeedX" },
                    { 9, 17000m, "21000", "Ducati Monster", "Italian bike", 2, 20, 1, "SpeedX" },
                    { 10, 16000m, "20000", "BMW GS", "Adventure bike", 2, 30, 1, "MotoWorld" },
                    { 11, 30000m, "36000", "Ford F150", "Pickup truck", 3, 70, 1, "TruckPro" },
                    { 12, 32000m, "38000", "RAM 1500", "Heavy duty truck", 3, 65, 1, "TruckPro" },
                    { 13, 29000m, "35000", "Toyota Tundra", "Reliable truck", 3, 50, 1, "TruckPro" },
                    { 14, 31000m, "37000", "Chevy Silverado", "Work truck", 3, 45, 1, "TruckPro" },
                    { 15, 28000m, "34000", "Nissan Titan", "Strong truck", 3, 35, 1, "TruckPro" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address1", "Address2", "City", "Country", "CreditLimit", "FirstName", "LastName", "Name", "Phone", "PostalCode", "SalesRepNum", "State" },
                values: new object[,]
                {
                    { 1, "Street 1", null, "NY", "USA", 50000m, "Kevin", "Lee", "AutoWorld", "1111", 10001, 3, "NY" },
                    { 2, "Street 2", null, "LA", "USA", 60000m, "Alex", "Kim", "SpeedCars", "2222", 90001, 3, "CA" },
                    { 3, "Street 3", null, "Paris", "France", 70000m, "Jean", "Dubois", "EuroMotors", "3333", 75000, 4, "Paris" },
                    { 4, "Street 4", null, "Berlin", "Germany", 55000m, "Max", "Schulz", "BerlinCars", "4444", 10115, 4, "Berlin" },
                    { 5, "Street 5", null, "Tokyo", "Japan", 80000m, "Ken", "Sato", "TokyoMotors", "5555", 150000, 5, "Tokyo" },
                    { 6, "Street 6", null, "NY", "USA", 45000m, "Chris", "Miller", "TruckHub", "6666", 10002, 5, "NY" },
                    { 7, "Street 7", null, "Tokyo", "Japan", 62000m, "Li", "Tan", "MotoX", "7777", 150001, 6, "Tokyo" },
                    { 8, "Street 8", null, "LA", "USA", 48000m, "Sam", "White", "ClassicRide", "8888", 90002, 6, "CA" },
                    { 9, "Street 9", null, "NY", "USA", 53000m, "Carlos", "Lopez", "FastLane", "9999", 10003, 3, "NY" },
                    { 10, "Street 10", null, "Paris", "France", 67000m, "Luis", "Garcia", "PrimeAuto", "1010", 75001, 4, "Paris" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Comments", "CustomerID", "OrderDate", "RequireDate", "ShippedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Delivered", 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "Delivered", 2, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, "Delivered", 3, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, "Delivered", 4, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, "Delivered", 5, new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, "Delivered", 6, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, "Delivered", 7, new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, "Delivered", 8, new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, "Delivered", 9, new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, "Delivered", 10, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, "Delivered", 1, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, "Delivered", 2, new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 13, "Delivered", 3, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, "Delivered", 4, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 15, "Delivered", 5, new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Order_Products",
                columns: new[] { "Id", "OrderId", "ProductCode", "PriceEach", "Qty" },
                values: new object[,]
                {
                    { 1, 1, 1, 25000m, 1 },
                    { 2, 1, 6, 19000m, 2 },
                    { 3, 2, 2, 23000m, 1 },
                    { 4, 2, 7, 18000m, 1 },
                    { 5, 3, 3, 27000m, 1 },
                    { 6, 3, 11, 36000m, 1 },
                    { 7, 4, 4, 26000m, 1 },
                    { 8, 4, 8, 17500m, 2 },
                    { 9, 5, 5, 24000m, 1 },
                    { 10, 5, 9, 21000m, 1 },
                    { 11, 6, 6, 19000m, 1 },
                    { 12, 6, 12, 38000m, 1 },
                    { 13, 7, 7, 18000m, 1 },
                    { 14, 7, 13, 35000m, 1 },
                    { 15, 8, 8, 17500m, 1 },
                    { 16, 8, 14, 37000m, 1 },
                    { 17, 9, 9, 21000m, 1 },
                    { 18, 9, 15, 34000m, 1 },
                    { 19, 10, 10, 20000m, 1 },
                    { 20, 10, 1, 25000m, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 2, 1, 6 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 3, 2, 2 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 4, 2, 7 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 5, 3, 3 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 6, 3, 11 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 7, 4, 4 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 8, 4, 8 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 9, 5, 5 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 10, 5, 9 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 11, 6, 6 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 12, 6, 12 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 13, 7, 7 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 14, 7, 13 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 15, 8, 8 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 16, 8, 14 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 17, 9, 9 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 18, 9, 15 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 19, 10, 10 });

            migrationBuilder.DeleteData(
                table: "Order_Products",
                keyColumns: new[] { "Id", "OrderId", "ProductCode" },
                keyValues: new object[] { 20, 10, 1 });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Customers",
                newName: "Sate");

            migrationBuilder.AlterColumn<int>(
                name: "ReportsTo",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
