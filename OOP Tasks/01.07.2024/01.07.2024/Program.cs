using System;
using System;

public class Car
{
    // Properties
    public string Make { get; set; }
    public int Year { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
    public string Model { get; set; }
    public string PalletNo { get; set; }
    public string Color { get; set; }

    // Constructor
    public Car(string make, int year, string type, decimal price, string model, string palletNo, string color)
    {
        Make = make;
        Year = year;
        Type = type;
        Price = price;
        Model = model;
        PalletNo = palletNo;
        Color = color;
    }

    // Method to start the engine
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    // Method to stop the engine
    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }

    // Method to return full information about the car
    public string GetCarInfo()
    {
        return $"Make: {Make}, Year: {Year}, Type: {Type}, Price: {Price:C}, Model: {Model}, Pallet No: {PalletNo}, Color: {Color}";
    }
}

public class BMW : Car
{
    // Constructor
    public BMW(string make, int year, string type, decimal price, string model, string palletNo, string color)
        : base(make, year, type, price, model, palletNo, color)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a BMW object
        BMW myBMW = new BMW("BMW", 2023, "Sedan", 75000m, "M3", "123456", "Black");

        // Start the engine
        myBMW.StartEngine();

        // Print full information about the car
        Console.WriteLine(myBMW.GetCarInfo());

        // Stop the engine
        myBMW.StopEngine();
    }
}

