
namespace DAL
{
    public class Employee
    {
        
        public int Id { get; set; }
        public string Person_Number { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public virtual List<PhoneNumber> Phone_Number { get; set; }
        public virtual List<EMail> E_Mail { get; set; }
        public virtual List<Department>? Departments { get; set; }
        public virtual List<Product>? Products { get; set; }
        public virtual List<Employee>? Mentorship { get; set; }
    }
    public class PhoneNumber
    {
        public string Value { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
    public class EMail
    {
        public string Value { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}