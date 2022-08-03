using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class Employees : IEmployees
    {
        EmployeeDBContext _context;
        public Employees(EmployeeDBContext context)
        {
            _context = context;

        }
        public Employee createEmployee(Employee obj)
        {
            _context.Employees.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public Employee deleteEmployee(int id)
        {
            var obj = _context.Employees.Find(id);
            _context.Employees.Remove(obj);
            _context.SaveChanges();
            return obj;
        }

        public List<Employee> getAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee getEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }

        public Employee updateEmployee(Employee obj)
        {
            _context.Employees.Update(obj);
            _context.SaveChanges();
            return obj;
        }
    }
}
