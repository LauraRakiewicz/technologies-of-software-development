using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TSD.Linq.Cars;

namespace ConsoleApplication1
{
    class CarQuerries
    {
        private static string path = @"Files\carList.xml";
        private List<Car> carList;

        public CarQuerries()
        {
            carList = CarDataFileReader.ReadCarsFromCSVFile().ToList();
        }

        public void ExecuteQueries()
        {
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();

        }

        private List<CarGroup> Task4()
        {
            var bestSeller = carList.GroupBy(g => g.Make).Select(n => new CarGroup
            {
                Mark = n.Key,
                Count = n.Count()
            }).OrderByDescending(o => o.Count).Take(3).ToList();

            return bestSeller;
        }

        private List<Car> Task5()
        {
            return carList.Where(w => w.Sales2015 >= w.Sales2014 * 1.5).ToList();
        }

        private List<Car> Task6()
        {
            return carList.OrderBy(g => g.Sales2015).Skip(10).Take(3).ToList();
        }

        private int Task7()
        {
            return  carList.Sum(g => g.Sales2015) + carList.Sum(g => g.Sales2014);
        }

        private List<Car> Task8()
        {
            var top2015 = carList.OrderBy(g => g.Sales2015).Take(10);
            var top2015_2 = carList.OrderByDescending(g => g.Sales2015).Take(10);
            return top2015.Concat(top2015_2).ToList();
        }

        // Task 9
        public void SaveToXml()
        {
            XDocument objXml = new XDocument(
                new XElement("Cars", carList.Select(x => new XElement("Car",
                                               new XAttribute("Make", x.Make),
                                               new XAttribute("Sales2014", x.Sales2014),
                                               new XAttribute("Sales2015", x.Sales2015))))
                );

            objXml.Declaration = new XDeclaration("1.0", "utf-8", "true");
            objXml.Save(path);
        }

        // Task 10
        public void ReadFromXml()
        {
            XDocument doc = XDocument.Load(path);
            IEnumerable<Car> result = from c in doc.Element("Cars").Elements("Car")
                                      select new Car((string)c.Attribute("Make"))
                                      {
                                          Sales2015 = (int)c.Attribute("Sales2015"),
                                          Sales2014 = (int)c.Attribute("Sales2014")
                                      };
        }
    }
}
