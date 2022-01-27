using Service.DTOs;
using DAL;

namespace Service
{
    public class EmployeeService
    {
        private static EmployeeService _instance;
        public static EmployeeService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeeService();
                }
                return _instance;
            }
        }
        private EmployeeService() { }

        public int CountEmployees()
        {
            using (var context = new ContextFil())
            {
                var count = context.Employees
                    .Count();
                return count;
            }
        }
        public List<EmployeeDTOs> ListEmployee()
        {
            var employees = new List<EmployeeDTOs>();
            using (var context = new ContextFil())
            {                
                var AllEmployee = context.Employees
                   .ToList();
                var AllDepartments = context.Departments
                    .ToList();
                bool responsible = false;
                foreach (var employee in AllEmployee)
                {
                    foreach (var department in AllDepartments)
                    {
                        if (department.EmployeeId == employee.Id)
                        {
                            responsible = true;
                        }
                    }                  
                    employees.Add(new EmployeeDTOs
                    {
                        Name = $"{employee.First_Name} {employee.Last_Name}",
                        EmploResponsilbeForDepartments = responsible
                    });
                    responsible = false;
                }
            }           
            return employees;
        }

        /* The rest of the code is not included in the task */


        //public Employee ListEmployeeByID(int EmployeeID)
        //{
        //    using (var context = new ContextFil())
        //    {

        //        var p1 = context.Employees.Find(EmployeeID);
        //        return p1;
        //    }
        //}
        //public void AddEmployee(Employee employee)
        //{
        //    using (var context = new ContextFil())
        //    {
        //        context.Employees.Add(employee);
        //        context.SaveChanges();
        //    }
        //}
        //public void UpdateEmployee(EmployeeDTOs employee)
        //{
        //    using (var context = new ContextFil())
        //    {
        //        var employee1 = new Employee
        //        {
        //            Id = employee.Id,
        //            First_Name = employee.First_Name,
        //            Last_Name = employee.Last_Name,
        //            Person_Number = employee.Person_Number
        //        };
        //        context.Update(employee1);
        //        context.SaveChanges();
        //    }
        //}
        //public void DeleteEmployee(int employeenID)
        //{
        //    using (var context = new ContextFil())
        //    {
        //        var employee = context.Employees.First(t => t.Id == employeenID);
        //        context.Employees.Remove(employee);
        //        context.SaveChanges();
        //    }
        //}
    }
}

//        var p1 = context.Persons.Find("333"); // only primary key
//        var p2 = context.Persons.First(p => p.Name == "Calle");
//        var p3 = context.Persons.FirstOrDefault(p => p.Name == "Calle");
//        var p6 = context.Persons.Where(p => p.Name == "Calle").First();

//private static void SameEntityRelationship()
//{
//    using (var context = new MyDbContext())
//    {
//        var persons = context.Persons
//            //.Include(h => h.Owner)
//            .ToList();

//        foreach (var person in persons)
//        {
//            Console.WriteLine($"Person: {person.Name} with mother: {(person.Mother == null ? "no mother" : person.Mother.Name)} and father: {(person.Father == null ? "no father" : person.Father.Name)}");
//            Console.WriteLine($"Person: {person.Name} with number of mother children: {person.MotherChildren.Count}");
//            Console.WriteLine($"Person: {person.Name} with number of father children: {person.FatherChildren.Count}");
//        }

//        Console.ReadKey();
//    }
//}

