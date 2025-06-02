using System.ComponentModel.Design;
using Parprog3;
Console.WriteLine("Welcome to the Car Dealership");
CarDealerShip carDealerShip = new CarDealerShip();
Console.WriteLine("Please type your Name");
string name = Console.ReadLine() ?? "Guest";
UserClass user = new UserClass(name);

MainMenu(carDealerShip, user);

void MainMenu(CarDealerShip carDearlerShip, UserClass user)
{
    Console.WriteLine($"Hello {user.Name}");
    Console.WriteLine("Please Select one of the following options");
    Console.WriteLine("1. View Cars");
    Console.WriteLine("2. View Cars by year range");
    Console.WriteLine("3. View Cars by Mileage");
    Console.WriteLine("4. Exit program");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            carDealerShip.ViewCars();
            BoughtCar(carDealerShip, user);
            break;
        case "2":
            Console.WriteLine("Please enter the start year:");
            int startYear = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Please enter the end year:");
            int endYear = int.Parse(Console.ReadLine() ?? "0");
            carDealerShip.ViewCarsByYearRange(startYear, endYear);
            BoughtCar(carDealerShip, user);
            break;
        case "3":
            Console.WriteLine($"Do you want to sort the cars by mileage, low to high?");
            string sortChoice = Console.ReadLine()?.ToLower();
            var i = 0;
            carDealerShip.Cars.OrderBy(carDealerShip => carDealerShip.Kilometer).ToList().ForEach(car =>
            {
                Console.WriteLine($"{++i}).Model: {car.Model}, Year: {car.Year}, RegNr: {car.RegNr}, Kilometer: {car.Kilometer}");
            });
            BoughtCar(carDealerShip, user);
            break;
        case "4":
            Console.WriteLine("Thank you for visiting the Car Dealership. Goodbye!");
            Thread.Sleep(1000);
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice, please try again.");
            MainMenu(carDearlerShip, user);
            break;
    }
    MainMenu(carDealerShip, user);
}


void BoughtCar(CarDealerShip carDealerShip, UserClass user)
{
   var newCar = carDealerShip.BuyCar();
    user.Cars.Add(newCar);
}
