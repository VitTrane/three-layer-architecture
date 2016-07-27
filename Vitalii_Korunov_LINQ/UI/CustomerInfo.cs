using BLModels;
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
    public partial class CustomerInfoForm : Form
    {
        public string CustomerName 
        {
            get 
            {
                if (!String.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    return textBoxName.Text;
                }
                else
                {
                    MessageBox.Show("Поле \"имя\" обязательно для заполнения");
                    return "Имя";
                }
            }
            private set 
            {
                textBoxName.Text = value;
            }
        }

        public string SecondName
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(textBoxSecondName.Text))
                {
                    return textBoxSecondName.Text;
                }
                else
                {
                    MessageBox.Show("Поле \"Фамилия\" обязательно для заполнения");
                    return "Фамилия";
                }
            }
            private set
            {
                textBoxSecondName.Text = value;
            }
        }

        public string Patronymic
        {
            get
            {
                return textBoxPatronymic.Text;
            }
            private set
            {
                textBoxPatronymic.Text = value;
            }
        }

        public string FullName 
        {
            get
            {
                return SecondName + " " + CustomerName + " " + Patronymic;

            }
            private set
            {
                textBoxPatronymic.Text = value;
            }
        }

        public DateTime DateBirth
        {
            get
            {
                return dateTimePickerDateBirth.Value;
            }
            private set
            {
                dateTimePickerDateBirth.Value = value;
            }
        }

        public string BankName
        {
            get
            {
                if (comboBoxNamesBanks.SelectedItem != null)
                    return comboBoxNamesBanks.SelectedItem.ToString();
                else
                    return comboBoxNamesBanks.Items[0].ToString();
            }
            private set 
            {
                comboBoxNamesBanks.SelectedItem = value;
            }
        }

        public CustomerInfoForm(IEnumerable<string> namesBanks, Customer customer = null)
        {
            InitializeComponent();
            AddDataComboBox(namesBanks);

            if (customer != null)
                AddCustomerInfo(customer);
        }

        private void AddCustomerInfo(Customer customer) 
        {
            CustomerName = customer.Name;
            SecondName = customer.SecondName;
            Patronymic = customer.Patronymic;
            DateBirth = customer.DateBirth;
            BankName = customer.BankName;
        }

        private void AddDataComboBox(IEnumerable<string> namesBanks)
        {
            foreach (var name in namesBanks)
            {
                comboBoxNamesBanks.Items.Add(name);
            }
            comboBoxNamesBanks.SelectedItem = comboBoxNamesBanks.Items[0];
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
