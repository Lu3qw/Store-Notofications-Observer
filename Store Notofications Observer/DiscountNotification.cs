using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Notofications_Observer
{
    internal class DiscountNotification
    {
        private Dictionary<string, List<ICustomer>> subscribers;

        public DiscountNotification()
        {
            subscribers = new Dictionary<string, List<ICustomer>>();
        }

        public void AddSubscriber(string category, ICustomer customer)
        {
            if (!subscribers.ContainsKey(category))
            {
                subscribers[category] = new List<ICustomer>();
            }
            if (!subscribers[category].Contains(customer))
            {
                subscribers[category].Add(customer);
            }
        }

        public void RemoveSubscriber(string category, ICustomer customer)
        {
            if (subscribers.ContainsKey(category))
            {
                subscribers[category].Remove(customer);
            }
        }

        public void Notify(string category, string message)
        {
            if (subscribers.ContainsKey(category))
            {
                foreach (var subscriber in subscribers[category])
                {
                    subscriber.Update(category, message);
                }
            }
        }
    }
}
