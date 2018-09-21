using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC
{
    public class Facade
    {
        private Waiter waiter;
        private Kitchen kitchen;
        private Cashbox cashbox;

        public Facade(Waiter waiter, Kitchen kitchen, Cashbox cashbox)
        {
            this.waiter = waiter;
            this.kitchen = kitchen;
            this.cashbox = cashbox;
        }

        public void OperationLunch()
        {
            waiter.AcceptOrder();
            waiter.TransferOrderToKitchen();
            kitchen.AcceptOrder();
            kitchen.Cook();
            kitchen.Notify();
            waiter.GettingADishInKitchen();
            waiter.ServingGuests();
            waiter.Bill();
            cashbox.PrintReckoning();
            Console.WriteLine("Операция завршена!");
        }
    }
}
