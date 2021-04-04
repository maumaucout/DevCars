using DevCars.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.Persistence
{
    public class DevCarsDbContext
    {
        public DevCarsDbContext()
        {
            Cars = new List<Car>
            {
                new Car(1, "123ABC", "HONDA", "CIVIC", 2021, 100000, "CINZA", new DateTime(2021, 1, 1)),
                new Car(2, "456ABC", "TOYOTA", "COROLLA", 2020, 20000, "AZUL", new DateTime(2021, 2, 2)),
                new Car(3, "789ABC", "CHEVROLET", "ONIX", 2021, 70000, "BRANCO", new DateTime(2021, 1, 1)),
            };

            Customers = new List<Customer>
            { 
                new Customer(1, "ANDREW", "1234567", new DateTime(1990, 1, 1)),
                new Customer(2, "MAURICIO", "1234567", new DateTime(1990, 1, 1)),
                new Customer(3, "BRENON", "1234567", new DateTime(1990, 1, 1)),
            };
        }
        public List<Car> Cars { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
