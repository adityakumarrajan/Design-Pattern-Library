using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Contracts;

namespace DecoratorPattern.CustomizePizza
{
    public class VegPizza : PizzaDecorator
    {
        public VegPizza(IPizza inputPizza):base(inputPizza)
        {
        }
        public override void GetDescription()
        {
            objPizza.GetDescription();
            Console.WriteLine("Veg Toppings Added");
        }

        public override double GetPrice()
        {
            return objPizza.GetPrice() + 20.00;
        }
    }
}
