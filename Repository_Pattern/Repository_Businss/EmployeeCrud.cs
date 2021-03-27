using Repository_Businss.Interface;
using Repository_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Businss
{
    public class EmployeeCrud : IEmployee
    {
        Model1 db = new Model1();
        public Employee AddEmployee(Employee e)
        {
            Employee emp = new Employee()
            {
                Name=e.Name,
                Age=e.Age,
                Address=e.Address,
                Salary=e.Salary
            };
            db.Employees.Add(emp);
            db.SaveChanges();
            return emp;

        }

        public void DeleteEmployee(int id)
        {
            Employee emp = db.Employees.Where(n => n.ID == id).SingleOrDefault();
            db.Employees.Remove(emp);
            db.SaveChanges();
        }

        public Employee EditEmployee(Employee e)
        {
            Employee emp = db.Employees.Where(n => n.ID == e.ID).SingleOrDefault();
            emp.Name = e.Name;
            emp.Age = e.Age;
            emp.Address = e.Address;
            emp.Salary = e.Salary;
            db.SaveChanges();

            return emp;

        }

        public List<Employee> GetEmployees()
        {
            List<Employee> lst = db.Employees.ToList();
            return lst;
        }
       public Employee ShowEmployee(int id)
        {
            Employee emp = db.Employees.Where(n => n.ID == id).SingleOrDefault();
            return emp;
        }

    }
}
