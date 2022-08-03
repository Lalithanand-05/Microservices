using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication5.Models
{
    public interface IEmployees
    {
        public List<Employee> getAllEmployees();

        public Employee getEmployeeById(int id);

        public Employee createEmployee(Employee obj);
        public Employee updateEmployee(Employee obj);

        public Employee deleteEmployee(int id);
    }
}
