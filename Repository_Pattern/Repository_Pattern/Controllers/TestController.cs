using Repository_Businss.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository_Businss;
using Repository_Domain.Models;

namespace Repository_Pattern.Controllers
{
    public class TestController : Controller
    {
        private IEmployee emp;
        public TestController(EmployeeCrud emp)
        {
            this.emp = emp;
        }
        public ActionResult Index()
        {
            List<Employee> lst = emp.GetEmployees();
            return View(lst);
        }
        public ActionResult Edit(int id)
        {
           Employee e= emp.ShowEmployee(id);

            return View(e);
        }
        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            emp.EditEmployee(e);

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            emp.DeleteEmployee(id);

            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee e)
        {
            emp.AddEmployee(e);

            return RedirectToAction("Index");
        }
    }
}