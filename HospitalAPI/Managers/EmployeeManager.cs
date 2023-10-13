using HospitalAPI.Models;

namespace HospitalAPI.Managers
{
    public class EmployeeManager
    {
        private static int _nextId = 1;

        private static readonly List<Employee> Employees = new List<Employee>
        {
            new Employee(employeeId: _nextId, employeeName: "Anna Boelske", employeeInitials: "AnBo", employeeOccupation: "Nurse", employeeGender: "F"),
            new Employee(employeeId: _nextId, employeeName: "Jørgen Villius", employeeInitials: "JøVi", employeeOccupation: "Doctor", employeeGender: "M"),
            new Employee(employeeId: _nextId, employeeName: "Kim Possible", employeeInitials: "KiPo", employeeOccupation: "Phycisian", employeeGender: "NB")
        };

        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>(Employees);
            return employees;
        }


        public Employee GetByEmployeeNumber(int EmployeeId)
        {
            return Employees.Find(employee => employee.EmployeeId == EmployeeId);
        }

        public Employee Add(Employee newEmployee)
        {
            newEmployee.EmployeeId = _nextId++;
            Employees.Add(newEmployee);
            return newEmployee;
        }
    }
}
