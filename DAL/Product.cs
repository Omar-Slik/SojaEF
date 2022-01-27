namespace DAL
{
    public class Product
    {
        public int Id { get; set; }
        public string Bar_Code { get; set; }
        public int Number_In_Store { get; set; }
        public string Name { get; set; }
        public string? List_Of_Ingredients { get; set; }
        public DateTime Exe_Date { get; set; }
        public int Price { get; set; }
        public int? CampainId { get; set; }
        public virtual Campain? Campain { get; set; }
        public int? EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
        public DateTime? Date_Of_Last_Check { get; set; }
        public virtual ICollection<DepartmentProduct> DepartmentsProducts { get; set; }
    }
}
