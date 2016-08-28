using BLModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Repository
{
    public class DataAccess
    {        
        private static int id = 0;
        private static string _pathInputFile = AppDomain.CurrentDomain.BaseDirectory + "input.txt";
        private static string _pathOutputFile = AppDomain.CurrentDomain.BaseDirectory + "output.xml";

        /// <summary>
        /// Добавляет клиента в файл
        /// </summary>
        /// <param name="customer">Клиент, которого нужно добавить</param>
        public static void Create(Customer customer) 
        {
            using (TextWriter writer = new StreamWriter(_pathInputFile, true, Encoding.Default))
            {
                id++;
                customer.Id = id;
                string info = String.Format("{0}:{1}: {2} {3} {4}, {5}", 
                    customer.Id, customer.BankName, customer.SecondName,
                    customer.Name, customer.Patronymic, customer.DateBirth.ToShortDateString());

                writer.WriteLine(info);                
            }
        }

        /// <summary>
        /// Читает файл
        /// </summary>
        public static IDictionary<string,Bank> Read() 
        {
            IDictionary<string, Bank> _banks = new Dictionary<string, Bank>();            
            try
            {
                string[] lines = ReadFile();
                foreach (var line in lines)
                {
                    string[] info = line.Split(':', ',');
                    int customerId = int.Parse(info[0]);
                    string nameBank = info[1];
                    if (!_banks.ContainsKey(nameBank))
                    {
                        _banks.Add(nameBank, new Bank(nameBank));
                        _banks[nameBank].Customers.Add(new Customer(customerId,info[2], DateTime.Parse(info[3]), nameBank));
                    }
                    else
                    {
                        _banks[nameBank].Customers.Add(new Customer(customerId,info[2], DateTime.Parse(info[3]), nameBank));
                    }
                    id = customerId;
                }
            }
            catch (Exception)
            {                
                throw;
            }

            return _banks;
        }

        /// <summary>
        /// Добавляет в файл обновленного клиента
        /// </summary>
        /// <param name="updatedCustomer">Клиент, у которого обновили информацию</param>
        public static void Update(Customer updatedCustomer) 
        {            
            Create(updatedCustomer);
        }

        /// <summary>
        /// Удаляет из файла клиента
        /// </summary>
        /// <param name="customer">Клиент, которого нужно удалить</param>
        public static void Delete(Customer customer) 
        {
            string[] lines = ReadFile();
            //string info;
            //if (!String.IsNullOrWhiteSpace(customer.Patronymic))
            //{
            //    info = String.Format("{0}:{1}: {2} {3} {4}, {5}",
            //        customer.Id, customer.BankName, customer.SecondName,
            //        customer.Name, customer.Patronymic, customer.DateBirth.ToShortDateString());
            //}
            //else 
            //{
            //    info = String.Format("{0}:{1}: {1} {2}, {3}",
            //        customer.Id, customer.BankName, customer.SecondName,
            //        customer.Name, customer.DateBirth.ToShortDateString());
            //}

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(_pathInputFile, false, Encoding.Default))
            {
                int id = customer.Id;
                //string[] updateInfo = lines.Where(x=>!x.Contains(info)).ToArray();
                string[] updateInfo = lines.Where(x => !x.StartsWith(id.ToString())).ToArray();
                foreach (var str in updateInfo)
                {
                    file.WriteLine(str);
                }
            }
        }

        /// <summary>
        /// Читает все строки из файла
        /// </summary>
        private static string[] ReadFile() 
        {
            List<string> lines = new List<string>();
            try
            {
                if (!File.Exists(_pathInputFile))
                    File.Create(_pathInputFile);

                using (var streamReader = new StreamReader(_pathInputFile, Encoding.Default))
                {
                    while (!streamReader.EndOfStream)
                    {
                        lines.Add(streamReader.ReadLine());
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("При чтении файла произошла ошибка");
            }
            return lines.ToArray();
        }

        /// <summary>
        /// Записывает объект в xml файл
        /// </summary>
        /// <typeparam name="T">Тип записываемого объекта</typeparam>
        /// <param name="obj">Объект, который нужно записать</param>
        public static void WriteXmlFile<T>(object obj)
        {
            using (TextWriter writer = new StreamWriter(_pathOutputFile, false))
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                xml.Serialize(writer, obj);
            }
        }
    }
}
