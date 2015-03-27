using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Contracts
{
    public abstract class PizzaDecorator:IPizza
    {
        protected IPizza objPizza;

        public PizzaDecorator(IPizza inputPizzaObj)
        {
            this.objPizza = inputPizzaObj;
        }
        public abstract void GetDescription();

        public abstract double GetPrice();
    }
}
