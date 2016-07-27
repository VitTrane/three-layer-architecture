using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLModels
{
    [Serializable]
    public class Customer
    {
        private string _name;
        private string _secondName;
        private string _patronymic;
        private int _age;
        private DateTime _dateBirth;
        private string _bankName;

        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }

        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        public int Age
        {
            get { return _age; }
        }

        public DateTime DateBirth
        {
            get { return _dateBirth; }
            set
            {
                CalculateAge(value);
                _dateBirth = value;
            }
        }

        public string FullName 
        {
            get
            {
                return SecondName + " " + Name + " " + Patronymic;
            }
            set 
            {
                SplitFullName(value);
            }
        }

        public Customer()
        {
        }

        public Customer(string fullName, DateTime dateBirth, string bankName)
        {
            SplitFullName(fullName);
            _dateBirth = dateBirth;
            _bankName = bankName;
            CalculateAge(dateBirth);
        }

        public Customer(string secondName, string name, string patronymic, DateTime dateBirth)
        {
            _name = name;
            _secondName = secondName;
            _patronymic = patronymic;
            _dateBirth = dateBirth;
            CalculateAge(dateBirth);
        }

        /// <summary>
        /// Определяет возраст по дате рождения
        /// </summary>
        /// <param name="dateBirth">Дата рождения</param>
        private void CalculateAge(DateTime dateBirth)
        {
            int years = DateTime.Now.Year - dateBirth.Year;
            if (DateTime.Now.Month < dateBirth.Month || (DateTime.Now.Month == dateBirth.Month && DateTime.Now.Day < dateBirth.Day))
                years--;

            _age = years;
        }

        /// <summary>
        /// Достает фамилию, имя, отчество из полного имени
        /// </summary>
        /// <param name="fullName">Полное имя</param>
        private void SplitFullName(string fullName)
        {
            string[] partsName = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            _secondName = partsName[0];
            _name = partsName[1];

            if (partsName.Length > 2)
                _patronymic = partsName[2];
            else
               _patronymic= string.Empty;
        }
    }
}
