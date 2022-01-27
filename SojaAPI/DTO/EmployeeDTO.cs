using Service.DTOs;

namespace SojaAPI.DTO
{
    public class EmployeeDTO
    {
        public int EmployeeCount { get; set; }
        public List<EmployeeDTOs> EmployeeList { get; set; }
    }
}
