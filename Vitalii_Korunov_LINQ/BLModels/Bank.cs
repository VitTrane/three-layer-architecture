using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLModels
{
    [Serializable]
    public class Bank
    {
        private string _name;
        private List<Customer> _customers;

        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Bank()
        {

        }

        public Bank(string name)
        {
            _name = name;
            _customers = new List<Customer>();
        }

        public Bank(string name, IEnumerable<Customer> customers)
        {
            _name = name;
            _customers = new List<Customer>();
            _customers.AddRange(customers);
        }
    }
}
