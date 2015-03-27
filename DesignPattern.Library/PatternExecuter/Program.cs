using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern;

namespace PatternExecuter
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteDecorator objExecuteDecorator = new ExecuteDecorator();
            objExecuteDecorator.ExecuteDecoratorPattern();
            Console.ReadLine();
        }
    }
}
