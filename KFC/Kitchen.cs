using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC
{
    public class Kitchen
    {
        public void AcceptOrder() { Console.WriteLine("На кухне приняли заказ!"); }
        public void Cook() { Console.WriteLine("Готовка блюда!"); }
        public void Notify() { Console.WriteLine("Оповещение о готовности блюда!"); }
    }
}
