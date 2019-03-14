using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;
using TSD.Linq.Cars;

namespace TSD.Linq.Cars
{
    public class CarSalesBook
    {
        private IList<Car> _cars;

        public CarSalesBook()
        {
            _cars = GenerateCars();
        }

        private IList<Car> GenerateCars()
        {
            var cars = new List<Car>();
            Car car1 = new Car("Mini") { Sales2015 = 123, Sales2014 = 1234 };
            cars.Add(car1);

            IList<Car> carList2 = new List<Car>();
            {
                new Car("Skoda") { Sales2015 = 45529, Sales2014 = 45529 };
                new Car("Toyota") { Sales2015 = 31484, Sales2014 = 36465 };
                new Car("BMW") { Sales2015 = 9549, Sales2014 = 7714 };
            }
            IList<Car> sortedCars = cars.OrderBy(c => c.Sales2015).ToList();

            return sortedCars;
        }

        private IList<Car> ReadCarsFromFile()
        {
            return CarDataFileReader.ReadCarsFromCSVFile();
        }
    }
}
