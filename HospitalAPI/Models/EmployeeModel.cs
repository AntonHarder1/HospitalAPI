namespace HospitalAPI.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeInitials { get; set; }
        public string EmployeeOccupation { get; set; }
        public string EmployeeGender { get; set; }

        public Employee(int employeeId, string employeeName, string employeeInitials, string employeeOccupation, string employeeGender)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeInitials = employeeInitials;
            EmployeeOccupation = employeeOccupation;
            EmployeeGender = employeeGender;
        }

        public Employee()
        {

        }
    }
}
