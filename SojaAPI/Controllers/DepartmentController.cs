using Microsoft.AspNetCore.Mvc;
using Service;
using Service.DTOs;

namespace SojaAPI.Controllers
{
    [Route("Department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {


        [HttpGet("list")]
        public List<DepartmentDTOs> ListDepartmentWithEPostAdresses()
        {
            return DepartmentService.Instance.ListDepartmentWithEPostAdresses();
        }

        /* The rest of the code is not included in the task */


        //[HttpGet("{DepartmentId}")]
        //public Department ListDepartmentByID(int DepartmentID)
        //{
        //    return DepartmentService.Instance.ListDepartmentByID(DepartmentID);
        //}
        //[HttpPost]
        //public void AddDepartment(Department department)
        //{
        //    DepartmentService.Instance.AddDepartment(
        //        new Department()
        //        {

        //        }
        //    );
        //}
        //[HttpPut("{departmentId}")]
        //public void UpdateDepartment(int departmentId, Department department)
        //{
        //    DepartmentService.Instance.UpdateDepartment(
        //        new Department()
        //        {
        //        }
        //    );
        //}
        //[HttpDelete]
        //public void DeleteDepartment(int departmentID)
        //{
        //    DepartmentService.Instance.DeleteDepartment(departmentID);
        //}
        //[HttpGet("Count")]
        //public int CountDepartments()
        //{
        //    return
        //    DepartmentService.Instance.CountDepartments();
        //}
    }
}
