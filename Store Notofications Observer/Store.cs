using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Notofications_Observer
{
    internal class Store
    {
        private DiscountNotification discountNotification;

        public Store()
        {
            discountNotification = new DiscountNotification();
        }

        public void AddSubscriber(string category, ICustomer customer)
        {
            discountNotification.AddSubscriber(category, customer);
        }

        public void RemoveSubscriber(string category, ICustomer customer)
        {
            discountNotification.RemoveSubscriber(category, customer);
        }

        public void NotifyDiscounts(string category, string discountDetails)
        {
            discountNotification.Notify(category, discountDetails);
        }
    }
}