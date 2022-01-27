using Microsoft.AspNetCore.Mvc;
using Service;
using SojaAPI.DTO;

namespace SojaAPI.Controllers
{
    [Route("Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public EmployeeDTO ListEmployee()
        {
            var EmployeeDetails = new EmployeeDTO
            {
                EmployeeCount = EmployeeService.Instance.CountEmployees(),
                EmployeeList = EmployeeService.Instance.ListEmployee()
            };
            return EmployeeDetails;
        }
        
        /* The rest of the code is not included in the task */

        //[HttpGet("{EmployeeId}")]
        //public Employee ListEmployeeByID(int EmployeeID)
        //{
        //    return EmployeeService.Instance.ListEmployeeByID(EmployeeID);
        //}
        //[HttpPost]
        //public void AddEmployee(Employee employee)
        //{
        //    EmployeeService.Instance.AddEmployee(
        //        new Employee()
        //        {
        //            Id = employee.Id,
        //            First_Name = employee.First_Name,
        //            Last_Name = employee.Last_Name,
        //            Person_Number = employee.Person_Number,

        //        }
        //    );
        //}
        //[HttpPut("{employeeId}")]
        //public void UpdateEmployee(int employeeId, EmployeeDTOs employee)
        //{
        //    EmployeeService.Instance.UpdateEmployee(
        //        new EmployeeDTOs()
        //        {
        //            Id = employeeId,
        //            First_Name = employee.First_Name,
        //            Last_Name = employee.Last_Name,
        //            Person_Number = employee.Person_Number,
        //        }
        //    );
        //}
        //[HttpDelete]
        //public void DeleteEmployee(int employeenID)
        //{
        //    EmployeeService.Instance.DeleteEmployee(employeenID);
        //}
    }
}
