using BLModels;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class BanksLogic
    {
        private IDictionary<string, Bank> _banks;

        public BanksLogic()
        {
            _banks = new Dictionary<string, Bank>();
            _banks = DataAccess.Read();
        }

        /// <summary>
        /// Возвращает банк по названию
        /// </summary>
        /// <param name="bankName">Название банка</param>
        public Bank GetBank(string bankName) 
        {
            return _banks[bankName];
        }

        /// <summary>
        /// Возвращает названия банков
        /// </summary>
        public IEnumerable<string> GetNamesBanks() 
        {
            List<string> _namesBanks = new List<string>();
            foreach (var name in _banks.Keys)
            {
                _namesBanks.Add(name);
            }

            return _namesBanks;
        }

        /// <summary>
        /// Возвращает клиента
        /// </summary>
        /// <param name="id">Id клиента</param>
        /// <returns></returns>
        public Customer GetCustomer(int id) 
        {
            Customer customer = GetAllCustomers().FirstOrDefault(c => c.Id == id);
            return customer;
        }

        /// <summary>
        /// Возвращает клиентов банка
        /// </summary>
        /// <param name="bankName">Название банка</param>
        /// <returns></returns>
        public IEnumerable<Customer> GetAllCustomers(string bankName) 
        {
            return _banks[bankName].Customers;
        }

        /// <summary>
        /// Возвращает клинтов банков
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            foreach (var bank in _banks.Values)
            {
                customers.AddRange(bank.Customers);
            }

            return customers;
        }

        /// <summary>
        /// Добавляет нового клиента
        /// </summary>
        /// <param name="customer">Клиент, которого нужно добавить</param>
        public void AddCustomer(Customer customer) 
        {
            if (_banks.ContainsKey(customer.BankName))
            {
                _banks[customer.BankName].Customers.Add(customer);
                DataAccess.Create(customer);
            }
        }

        /// <summary>
        /// Обновляет клиента
        /// </summary>
        /// <param name="id">Id клиента</param>
        public void UpdateCustomer(Customer updatedCustomer)
        {
            DeleteCustomer(updatedCustomer.Id);
            AddCustomer(updatedCustomer);
        }

        /// <summary>
        /// Удаляет клиента
        /// </summary>
        /// <param name="id">Id клиента</param>
        public void DeleteCustomer(int id)
        {
            Customer customer = GetCustomer(id);
            _banks[customer.BankName].Customers.Remove(customer);
            DataAccess.Delete(customer);
        }

        /// <summary>
        /// Удаляет клиента
        /// </summary>
        /// <param name="customer">Клиент, которого нужно удалить</param>
        public void DeleteCustomer(Customer customer)
        {
            _banks[customer.BankName].Customers.Remove(customer);
            DataAccess.Delete(customer);
        }

        /// <summary>
        /// Сохраняет отфильтрованных клиентов
        /// </summary>
        /// <param name="customers">Список клиентов, который нужно сохранить</param>
        public void SaveFiltredCustomers(List<Customer> customers) 
        {
            DataAccess.WriteXmlFile<List<Customer>>(customers);
        }
    }
}
