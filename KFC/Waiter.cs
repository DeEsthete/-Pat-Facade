using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC
{
    public class Waiter
    {
        public void AcceptOrder() { Console.WriteLine("Официант принял заказ!"); }
        public void TransferOrderToKitchen() { Console.WriteLine("Официант передал заказ на кухню!"); }
        public void GettingADishInKitchen() { Console.WriteLine("Официант получил блюдо на кухне!"); }
        public void ServingGuests() { Console.WriteLine("Официант подал блюдо!"); }
        public void Bill() { Console.WriteLine("Официант выставил счет!"); }
    }
}
