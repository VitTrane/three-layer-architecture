using BLModels;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private BanksLogic _banksLogic;

        public HomeController()
        {
            _banksLogic = new BanksLogic();
        }

        public ActionResult CreateCustomer() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {
            Customer newCustomer = new Customer(customer.Id,customer.SecondName,customer.Name,customer.Patronymic,customer.DateBirth,customer.BankName);
            _banksLogic.AddCustomer(newCustomer);
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            var customers =  _banksLogic.GetAllCustomers();
            return View(customers);
        }

        public ActionResult EditCustomer(int id)
        {
            Customer customer = _banksLogic.GetCustomer(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult EditCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _banksLogic.UpdateCustomer(customer);
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        public ActionResult Delete(Customer viewCustomer) 
        {
            return View(viewCustomer);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Customer viewCustomer)
        {
            Customer customer =_banksLogic.GetCustomer(viewCustomer.Id);
            _banksLogic.DeleteCustomer(customer);
            return RedirectToAction("Index");
        }
    }
}
