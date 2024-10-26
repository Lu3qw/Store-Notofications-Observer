using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Store_Notofications_Observer
{
    internal class Customer : ICustomer
    {
        public string Name { get; private set; }
        private List<string> subscribedCategories;

        public Customer(string name)
        {
            Name = name;
            subscribedCategories = new List<string>();
        }

        public void Subscribe(Store store, string category)
        {
            if (!subscribedCategories.Contains(category))
            {
                subscribedCategories.Add(category);
                store.AddSubscriber(category, this);
            }
            else
            {
                Console.WriteLine($"{Name} already subscribed to category {category}");
            }
        }

        public void Unsubscribe(Store store, string category)
        {
            if (subscribedCategories.Contains(category))
            {
                subscribedCategories.Remove(category);
                store.RemoveSubscriber(category, this);
            }
            else
            {
                Console.WriteLine($"{Name} not subscribed to category {category}");
            }
        }

        public void Update(string category, string message)
        {
            Console.WriteLine($"{Name} recieve message to {category}: {message}");
        }
    }
}
