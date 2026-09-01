using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList; // field
        public MockEmployeeRepository()       // ctor
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "Mary@abv.bg" },
                new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "John@abv.bg" },
                new Employee() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "Sam@abv.bg" }
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1; // max id form the list + 1 = new id   
            _employeeList.Add(employee); // add new employee object to the list   
            return employee;             // return that object
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id) //incoming id
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id); //matches with the incoming id
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
