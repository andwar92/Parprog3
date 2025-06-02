using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprog3
{
    internal class CarDealerShip
    {
        public List<Cars> Cars = new List<Cars> {
        new Cars("Toyota", 1997, "PP1234",135000),
        new Cars("Honda", 2005, "QQ5678", 80000),
        new Cars("Nissan", 2010, "RR91011", 60000),
        new Cars("Audi",2021,"PP4321",67000),
        new Cars("Ford", 2021, "EF11223", 20000 ),
        new Cars("Volkswagen", 2018, "GH44556", 40000),
        new Cars("BMW", 2020, "IJ77889", 30000),
        new Cars("Mercedes", 2019, "KL99000", 50000),
        };

        public void ViewCars()
        {
            var i = 0;
            foreach (var car in Cars)
            {
                Console.WriteLine($"{++i}). Model: {car.Model}, Year: {car.Year}, RegNr: {car.RegNr}, Kilometer: {car.Kilometer}");
            }
        }
        public void ViewCarsByYearRange(int min, int max)
        {
            Console.WriteLine($"Cars from {min} to {max}:");
            var i = 0;
            foreach (var car in Cars.Where(car => car.Year >= min && car.Year <= max))
            {
                Console.WriteLine($"{++i}). Model: {car.Model}, Year: {car.Year}, RegNr: {car.RegNr}, Kilometer: {car.Kilometer}");
            }
        }

        public Cars BuyCar()
        {
            Console.WriteLine("Please select which car you want to buy!");
            var userInput = Console.ReadLine();
            if (int.TryParse(userInput, out var carChoice) && carChoice > 0 && carChoice <= Cars.Count)
            {
                Console.WriteLine($"Congrats on the new car\n{Cars[carChoice - 1].Model}");
                return Cars[carChoice - 1];
            }
            else
            {
                Console.WriteLine("Invalid choice");
                return null;
            }
        }
    }

};
