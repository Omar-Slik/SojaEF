

namespace DAL
{
    public class DepartmentProduct
    {
        public int DepartmentsId { get; set; }
        public virtual Department Department { get; set; }
        public int ProductsId { get; set; }
        public virtual Product Product { get; set; }
    }
}
