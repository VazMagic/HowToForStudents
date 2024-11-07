using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowTo.Models
{
    public class PersonsModel
    {
        public string Person { get; set; }

        public PersonsModel()
        {

        }

        public PersonsModel(string p)
        {
            Person = p;
        }

        public static List<PersonsModel> GetCustomers()
        {
            return new List<PersonsModel>
            {
               new PersonsModel("Customer 1"),
               new PersonsModel("Customer 2"),
               new PersonsModel("Customer 3")
            };
        }
    }
}
