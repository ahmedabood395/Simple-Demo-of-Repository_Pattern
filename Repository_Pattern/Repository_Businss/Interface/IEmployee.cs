using Repository_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Businss.Interface
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        Employee AddEmployee(Employee e);
        Employee EditEmployee(Employee e);
        Employee ShowEmployee(int id);
        void DeleteEmployee(int id);

    }
}
