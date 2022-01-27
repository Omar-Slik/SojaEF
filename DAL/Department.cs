

namespace DAL
{
    public class Department
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee ResponsibleEmployee { get; set; }
        public virtual ICollection<DepartmentProduct>? DepartmentsProducts { get; set; }
    }    
}
