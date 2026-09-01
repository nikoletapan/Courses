using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);           // Read
        IEnumerable<Employee> GetAllEmployee();
        Employee Add(Employee employee);          // Create
        Employee Update(Employee employeeChanges);// Update
        Employee Delete(int id);                  // Delete
    }
}
