using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade(new Waiter(), new Kitchen(), new Cashbox());
            facade.OperationLunch();
            Console.ReadLine();
        }
    }
}
