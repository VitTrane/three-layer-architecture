using BLModels;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        private BanksLogic banksLogic;
        private List<Customer> _customers;

        public Form1()
        {   
            InitializeComponent();

            banksLogic = new BanksLogic();
            _customers = new List<Customer>();
            _customers = banksLogic.GetAllCustomers().ToList();
            AddCustomersInListView(_customers);
        }

        private void AddCustomersInListView(List<Customer> customers) 
        {  
            foreach (var customer in customers)
            {
                AddCustomerInListView(customer);
            }
        }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerInfoForm cutomerInfoForm = new CustomerInfoForm(banksLogic.GetNamesBanks());
            if (cutomerInfoForm.ShowDialog() == DialogResult.OK) 
            {
                Customer customer = new Customer(cutomerInfoForm.FullName, cutomerInfoForm.DateBirth, cutomerInfoForm.BankName);
                banksLogic.AddCustomer(customer);
                AddCustomerInListView(customer);
            }
        }

        private void AddCustomerInListView(Customer customer) 
        {
            customersListView.Items.Add(customer.SecondName);
            customersListView.Items[customersListView.Items.Count - 1].Tag = customer;
            customersListView.Items[customersListView.Items.Count - 1].SubItems.Add(customer.Name);
            customersListView.Items[customersListView.Items.Count - 1].SubItems.Add(customer.Patronymic);
            customersListView.Items[customersListView.Items.Count - 1].SubItems.Add(customer.Age.ToString());
            customersListView.Items[customersListView.Items.Count - 1].SubItems.Add(customer.BankName);
        }

        private void удалитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customersListView.SelectedItems.Count > 0)
            {
                Customer selectedCustomer = GetSelectedCustomer();
                ListViewItem selectedItem = customersListView.SelectedItems[0];
                _customers.Remove(selectedCustomer);
                customersListView.Items.Remove(selectedItem);
                banksLogic.DeleteCustomer(selectedCustomer);
            }
        }

        private Customer GetSelectedCustomer()
        {
            Customer selectedCustomer = null;
            if (customersListView.SelectedItems.Count > 0)
            {
                ListViewItem item = customersListView.SelectedItems[0];
                foreach (var customer in _customers)
                {
                    if (item.Tag == customer)
                    {
                        selectedCustomer = customer;
                    }
                }
            }
            return selectedCustomer;
        }

        private void редактироватьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customersListView.SelectedItems.Count > 0)
            {
                Customer selectedCustomer = GetSelectedCustomer();
                ListViewItem selectedItem = customersListView.SelectedItems[0];
                CustomerInfoForm cutomerInfoForm = new CustomerInfoForm(banksLogic.GetNamesBanks(), selectedCustomer);
                if (cutomerInfoForm.ShowDialog() == DialogResult.OK)
                {
                    Customer updateCustomer = new Customer(cutomerInfoForm.FullName, cutomerInfoForm.DateBirth, cutomerInfoForm.BankName);

                    customersListView.Items[selectedItem.Index].Tag = updateCustomer;
                    customersListView.Items[selectedItem.Index].Text = updateCustomer.SecondName;
                    customersListView.Items[selectedItem.Index].SubItems[1].Text = updateCustomer.Name;
                    customersListView.Items[selectedItem.Index].SubItems[2].Text = updateCustomer.Patronymic;
                    customersListView.Items[selectedItem.Index].SubItems[3].Text = updateCustomer.Age.ToString();
                    customersListView.Items[selectedItem.Index].SubItems[4].Text = updateCustomer.BankName;

                    _customers.Add(updateCustomer);
                    _customers.Remove(selectedCustomer);
                    banksLogic.UpdateCustomer(selectedCustomer,updateCustomer);
                }
            }
        }

        private void поФамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterCustomers(CustomerFilter.FilterBySecondName, _customers);
        }

        private void поИмениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterCustomers(CustomerFilter.FilterByName, _customers);
        }

        private void поОтчествуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterCustomers(CustomerFilter.FilterByPatronymic, _customers);
        }

        private void поНазваниюБанкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterCustomers(CustomerFilter.FilterByBankName, _customers);
        }

        private void FilterCustomers(Func<List<Customer>, string, List<Customer>> func, List<Customer> customers) 
        {
            FilterForm filterForm = new FilterForm();
            if (filterForm.ShowDialog() == DialogResult.OK)
            {
                customersListView.Items.Clear();
                List<Customer> c = func(customers, filterForm.Filter);
                AddCustomersInListView(c);
                banksLogic.SaveFiltredCustomers(c);
            }
        }

        private void показатьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customersListView.Items.Clear();
            AddCustomersInListView(_customers);
        }
    }
}
