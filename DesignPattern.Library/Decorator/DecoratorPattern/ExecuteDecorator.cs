using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.CustomizePizza;

namespace DecoratorPattern
{
    public class ExecuteDecorator
    {
        public void ExecuteDecoratorPattern()
        {
            //Order from Pizza 
            IPizza objPizza = new PlainPizza();

            //Decorate Pizza with toppings.
            var vegtoppings = new VegPizza(objPizza);
            var extraCheese = new ExtraCheese(vegtoppings);
            extraCheese.GetDescription();
         
            //Check The output.
            Console.WriteLine(string.Format("Price Of Pizza is {0}", extraCheese.GetPrice()));
            
        }
    }
}
