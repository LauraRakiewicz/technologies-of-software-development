using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSD.Linq.Cars
{

    public class Car: IComparable<Car>
    {
        public string Make { get; }
        public int Sales2015 { get; set; }
        public int Sales2014 { get; set; }
        public int? NumberOfSeats { get; set; }

        public Car(string make)
        {
            this.Make = make;
        }

        public int CompareTo(Car other)
        {
            throw new NotImplementedException();
        }

        public int GetNumeberOfSeats()
        {
            var numberOfSeats = this.NumberOfSeats ?? default(int);
            return numberOfSeats;
        }
        
    }


}
