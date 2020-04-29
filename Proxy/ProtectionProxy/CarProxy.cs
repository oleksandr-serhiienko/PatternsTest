using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.ProtectionProxy
{
    public class CarProxy : ICar
    {
        private Driver driver;
        private Car car = new Car();
        public CarProxy(Driver driver)
        {
            this.driver = driver;
        }

        public void Drive()
        {
            if (driver.Age >= 16)
                car.Drive();
            else
                Console.WriteLine("Too young");
        }
    }
}
