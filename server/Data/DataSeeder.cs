using SRMPay.Entities;
using SRMPay.Enums;

namespace SRMPay.Data;

public static class DataSeeder
{
    public static void Seed(SRMPayContext db)
    {
        SeedVendors(db);
        SeedStudents(db);

        db.SaveChanges();
    }

    private static void SeedVendors(SRMPayContext db)
    {
        if (db.Vendors.Any()) return;

        var campusCafe = new Vendor
        {
            Name = "Campus Cafe",
            Type = VendorType.Food,
            Description = "Quick bites, sandwiches and beverages.",
            Location = "TP Ganesan Food Court",
            OperatingHours = "8:00 AM - 8:00 PM",
            Email = "campuscafe@srmpay.local",
            PasswordHash = "password",
            IsQueueEnabled = true
        };

        campusCafe.Products.Add(new Product
        {
            Name = "Veg Sandwich",
            Description = "Grilled vegetable sandwich.",
            Type = ProductType.Food,
            Price = 50
        });

        campusCafe.Products.Add(new Product
        {
            Name = "French Fries",
            Description = "Crispy salted fries.",
            Type = ProductType.Food,
            Price = 70
        });

        campusCafe.Products.Add(new Product
        {
            Name = "Veg Burger",
            Description = "Classic vegetable burger.",
            Type = ProductType.Food,
            Price = 80
        });

        campusCafe.Products.Add(new Product
        {
            Name = "Cold Coffee",
            Description = "Chilled coffee with ice cream.",
            Type = ProductType.Drink,
            Price = 90
        });

        var juicyJunction = new Vendor
        {
            Name = "Juicy Junction",
            Type = VendorType.Beverages,
            Description = "Fresh fruit juices, milkshakes and smoothies.",
            Location = "University Food Court",
            OperatingHours = "9:00 AM - 7:00 PM",
            Email = "juicyjunction@srmpay.local",
            PasswordHash = "password",
            IsQueueEnabled = true
        };

        juicyJunction.Products.Add(new Product
        {
            Name = "Orange Juice",
            Description = "Freshly squeezed orange juice.",
            Type = ProductType.Drink,
            Price = 70
        });

        juicyJunction.Products.Add(new Product
        {
            Name = "Watermelon Juice",
            Description = "Fresh watermelon juice.",
            Type = ProductType.Drink,
            Price = 60
        });

        juicyJunction.Products.Add(new Product
        {
            Name = "Chocolate Milkshake",
            Description = "Rich chocolate milkshake.",
            Type = ProductType.Drink,
            Price = 110
        });

        juicyJunction.Products.Add(new Product
        {
            Name = "Mango Smoothie",
            Description = "Seasonal mango smoothie.",
            Type = ProductType.Drink,
            Price = 120
        });

        var printHub = new Vendor
        {
            Name = "Print Hub",
            Type = VendorType.Printing,
            Description = "Printing, photocopying and document binding.",
            Location = "Academic Block 1",
            OperatingHours = "9:00 AM - 6:00 PM",
            Email = "printhub@srmpay.local",
            PasswordHash = "password",
            IsQueueEnabled = false
        };

        printHub.Products.Add(new Product
        {
            Name = "Black & White Print",
            Description = "Single A4 page.",
            Type = ProductType.Printing,
            Price = 2
        });

        printHub.Products.Add(new Product
        {
            Name = "Colour Print",
            Description = "Single A4 page.",
            Type = ProductType.Printing,
            Price = 10
        });

        printHub.Products.Add(new Product
        {
            Name = "Document Binding",
            Description = "Spiral binding service.",
            Type = ProductType.Service,
            Price = 40
        });

        printHub.Products.Add(new Product
        {
            Name = "Lamination",
            Description = "A4 lamination.",
            Type = ProductType.Service,
            Price = 30
        });

        var stationeryCorner = new Vendor
        {
            Name = "Stationery Corner",
            Type = VendorType.Stationery,
            Description = "Daily academic essentials.",
            Location = "Near Main Library",
            OperatingHours = "8:30 AM - 6:30 PM",
            Email = "stationery@srmpay.local",
            PasswordHash = "password",
            IsQueueEnabled = false
        };

        stationeryCorner.Products.Add(new Product
        {
            Name = "Notebook",
            Description = "200-page notebook.",
            Type = ProductType.Stationery,
            Price = 60
        });

        stationeryCorner.Products.Add(new Product
        {
            Name = "Blue Pen",
            Description = "Ball point pen.",
            Type = ProductType.Stationery,
            Price = 15
        });

        stationeryCorner.Products.Add(new Product
        {
            Name = "Scientific Calculator",
            Description = "Casio scientific calculator.",
            Type = ProductType.Stationery,
            Price = 650
        });

        stationeryCorner.Products.Add(new Product
        {
            Name = "Record Sheets",
            Description = "Pack of 100 A4 sheets.",
            Type = ProductType.Stationery,
            Price = 120
        });

        var campusPharmacy = new Vendor
        {
            Name = "Campus Pharmacy",
            Type = VendorType.Pharmacy,
            Description = "Medicines and first aid essentials.",
            Location = "Health Centre",
            OperatingHours = "8:00 AM - 10:00 PM",
            Email = "pharmacy@srmpay.local",
            PasswordHash = "password",
            IsQueueEnabled = false
        };

        campusPharmacy.Products.Add(new Product
        {
            Name = "Paracetamol",
            Description = "500mg tablet strip.",
            Type = ProductType.Other,
            Price = 25
        });

        campusPharmacy.Products.Add(new Product
        {
            Name = "Bandage Roll",
            Description = "Elastic bandage.",
            Type = ProductType.Other,
            Price = 45
        });

        campusPharmacy.Products.Add(new Product
        {
            Name = "Antiseptic Cream",
            Description = "First aid antiseptic cream.",
            Type = ProductType.Other,
            Price = 85
        });

        db.Vendors.AddRange(
            campusCafe,
            juicyJunction,
            printHub,
            stationeryCorner,
            campusPharmacy
        );
    }

    private static void SeedStudents(SRMPayContext db)
    {

    }
}
