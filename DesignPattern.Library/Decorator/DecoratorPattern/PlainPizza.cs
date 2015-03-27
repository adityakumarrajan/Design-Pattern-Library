using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class PlainPizza:IPizza
    {

        public void GetDescription()
        {
            Console.WriteLine("Pizza plain crust added");
        }

        public double GetPrice()
        {
            return 10.00;
        }
    }
}
