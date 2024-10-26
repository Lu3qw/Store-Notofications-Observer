using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Notofications_Observer
{
    public interface ICustomer
    {
        void Update(string category, string message);
    }
}
