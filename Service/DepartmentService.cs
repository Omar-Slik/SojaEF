using DAL;
using Service.DTOs;

namespace Service
{
    public class DepartmentService
    {
        private static DepartmentService _instance;
        public static DepartmentService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DepartmentService();
                }
                return _instance;
            }
        }
        private DepartmentService() { }

        public List<DepartmentDTOs> ListDepartmentWithEPostAdresses()
        {
            using (var context = new ContextFil())
            {

                var list = new List<DepartmentDTOs>();
                var departments = context.Departments
                    .ToList()
                    ;
                foreach (var dept in departments)
                {
                    var department = new DepartmentDTOs();
                    department.DepartmentsName = dept.Name;
                    var tmpEmail = context.EMail
                        .Where(email => email.EmployeeId == dept.Id)
                        .ToList()
                        ;
                    department.ResponsibleEmployeeMails = new List<String>();

                    foreach (var Mail in tmpEmail)
                    {
                        department.ResponsibleEmployeeMails.Add(Mail.Value);
                    }
                    list.Add(department);
                }
                return list;
            }
        }

        
        /* The rest of the code is not included in the task */

        //public void AddDepartment(Department department)
        //{
        //    using (var context = new ContextFil())
        //    {
        //        context.Departments.Add(department);
        //        context.SaveChanges();
        //    }
        //}
        //public Department ListDepartmentByID(int DepartmentID)
        //{
        //    using (var context = new ContextFil())
        //    {
        //        var p1 = context.Departments.Find(DepartmentID);
        //        return p1;
        //    }
        //}
        //public void UpdateDepartment(Department department)
        //{
        //    using (var context = new ContextFil())
        //    {
        //        context.Update(department);
        //        context.SaveChanges();
        //    }
        //}
        //public void DeleteDepartment(int departmentID)
        //{
        //    using (var context = new ContextFil())
        //    {
        //        var department = context.Departments.First(t => t.Id == departmentID);
        //        context.Departments.Remove(department);
        //        context.SaveChanges();
        //    }
        //}
        //public int CountDepartments()
        //{
        //    using (var context = new ContextFil())
        //    {
        //        var count = context.Departments
        //            .Count();
        //        return count;
        //    }
        //}

        //private static void ReadWithRelations()
        //{
        //    using (var context = new ContextFil())
        //    {
        //        var Department = context.Departments
        //            .First(h => h.EmployeeId != null);


        //    }
        //}
    }
}
