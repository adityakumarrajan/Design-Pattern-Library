using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Contracts;

namespace DecoratorPattern.CustomizePizza
{
    public class ExtraCheese:PizzaDecorator
    {
        public ExtraCheese(IPizza inputPizza)
            : base(inputPizza)
        {

        }
        public override void GetDescription()
        {
            objPizza.GetDescription();
            Console.WriteLine("Extra Cheese Added to pizza");
        }

        public override double GetPrice()
        {
            return objPizza.GetPrice() + 10.00;
        }
    }
}
