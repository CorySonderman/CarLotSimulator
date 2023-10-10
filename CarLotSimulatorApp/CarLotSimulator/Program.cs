using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var lot = new CarLot();
            
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            var stock1 = new Car();
            stock1.Year = 2007;
            stock1.Make = "Koenigsegg";
            stock1.Model = "CCXR";
            stock1.EngineNoise = "Sporty";
            stock1.HonkNoise = "Works";
            stock1.IsDriveable = true;
            stock1.Price = 4200000;
            lot.Inventory.Add(stock1);

            var stock2 = new Car()
            {
                Year = 1993,
                Make = "Jaguar",
                Model = "XJ220",
                EngineNoise = "Sporty",
                HonkNoise = "Works",
                Price = 500000,
                IsDriveable = true           
            };
            lot.Inventory.Add(stock2);
            var stock3 = new Car(1990, "Geo", "Metro", "None", "Does not beep", false, 1);
            lot.Inventory.Add(stock3);

            //Call each of the methods for each car
            stock1.MakeHonkNoise(stock1.HonkNoise);
            stock2.MakeHonkNoise(stock2.HonkNoise);
            stock3.MakeHonkNoise(stock3.HonkNoise);
            Console.WriteLine();
            stock1.MakeEngineNoise(stock1.EngineNoise);
            stock2.MakeEngineNoise(stock2.EngineNoise);
            stock3.MakeEngineNoise(stock3.EngineNoise);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine();
            Console.WriteLine("Welcome to Red's Exotics. Here's a list of our current inventory!");
            Console.WriteLine();
            foreach (var car in lot.Inventory)
            {
                
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model} Price: ${car.Price}");
            }
            Console.WriteLine();
            Console.WriteLine($"Number of cars in inventory: {CarLot.numberOfCars}");
        }
    }
}
