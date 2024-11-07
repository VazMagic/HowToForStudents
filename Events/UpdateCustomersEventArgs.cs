using HowTo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowTo.Events
{
    public class UpdateCustomersEventArgs : EventArgs
    {
        //ArrayList
        private List<PersonsModel> customers = new List<PersonsModel>();
        
        public UpdateCustomersEventArgs(List<PersonsModel> c)
        {
            customers = c;
        }

        public List<PersonsModel> GetCustomers
        {
            get
            {
                return customers;
            }
        }

    }
}
