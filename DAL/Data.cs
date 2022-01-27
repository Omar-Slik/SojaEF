using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public static class Data
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            #region(Employees)
            var e1 = new Employee()
            {
                Id = 1,
                Person_Number = "9004072142",
                First_Name = "Omar",
                Last_Name = "slik",
            };
            var e2 = new Employee()
            {
                Id = 2,
                Person_Number = "9407247294",
                First_Name = "Ulf",
                Last_Name = "Hedberg",
            };
            var e3 = new Employee()
            {
                Id = 3,
                Person_Number = "9112314292",
                First_Name = "Agda",
                Last_Name = "Erikson",
            };
            var e4 = new Employee()
            {
                Id = 4,
                Person_Number = "9506053255",
                First_Name = "Samauel",
                Last_Name = "Norlund",
            };
            var e5 = new Employee()
            {
                Id = 5,
                Person_Number = "8801013287",
                First_Name = "Erik",
                Last_Name = "Anderson",
            };
            var e6 = new Employee()
            {
                Id = 6,
                Person_Number = "8909034212",
                First_Name = "Pelle",
                Last_Name = "Haglund",
            };
            var e7 = new Employee()
            {
                Id = 7,
                Person_Number = "9906024632",
                First_Name = "Albin",
                Last_Name = "Eklund",
            };
            var e8 = new Employee()
            {

                Id = 8,
                Person_Number = "9007068576",
                First_Name = "Victoria",
                Last_Name = "Husak",
            };
            modelBuilder.Entity<Employee>()
                   .HasData(e1, e2, e3, e4, e5, e6, e7, e8)
                   ;
            //PhoneNumbers
            var pn1 = new PhoneNumber { Value = "0790763259", EmployeeId = 1 };
            var pn2 = new PhoneNumber { Value = "0753982342", EmployeeId = 2 };
            var pn3 = new PhoneNumber { Value = "0702397109", EmployeeId = 3 };
            var pn4 = new PhoneNumber { Value = "0742315214", EmployeeId = 4 };
            var pn5 = new PhoneNumber { Value = "0709523021", EmployeeId = 5 };
            var pn6 = new PhoneNumber { Value = "0767415941", EmployeeId = 6 };
            var pn7 = new PhoneNumber { Value = "0743268453", EmployeeId = 7 };
            var pn8 = new PhoneNumber { Value = "0790765689", EmployeeId = 8 };
            var pn9 = new PhoneNumber { Value = "0753982342", EmployeeId = 7 };
            var pn10 = new PhoneNumber { Value = "0753161642", EmployeeId = 2 };
            var pn11 = new PhoneNumber { Value = "0753473782", EmployeeId = 1 };
            modelBuilder.Entity<PhoneNumber>()
               .HasData(pn1, pn2, pn3, pn4, pn5, pn6, pn7, pn8, pn9, pn10, pn11)
               ;
            //EMails
            var em1 = new EMail { Value = "omar.slik@outlook.com", EmployeeId = 1 };
            var em12 = new EMail { Value = "omar.slik@hotmail.com", EmployeeId = 1 };
            var em13 = new EMail { Value = "omar.slik@gmail.com", EmployeeId = 1 };
            var em14 = new EMail { Value = "omar.slik@studerande-skys.com", EmployeeId = 1 };
            var em2 = new EMail { Value = "Adham.samauelson@outlook.com", EmployeeId = 2 };
            var em3 = new EMail { Value = "Agda.erikson@outlook.com", EmployeeId = 3 };
            var em4 = new EMail { Value = "Samauel.Norlund@outlook.com", EmployeeId = 4 };
            var em5 = new EMail { Value = "erik.anderson@outlook.com", EmployeeId = 5 };
            var em6 = new EMail { Value = "pelle.haglund@outlook.com", EmployeeId = 6 };
            var em7 = new EMail { Value = "albin.eklund@outlook.com", EmployeeId = 7 };
            var em8 = new EMail { Value = "victoria.Husak@outlook.com", EmployeeId = 8 };
            var em9 = new EMail { Value = "victoria.Husak@hotmail.com", EmployeeId = 8 };
            var em10 = new EMail { Value = "albin.eklund@gmail.com", EmployeeId = 7 };
            var em11 = new EMail { Value = "erik.anderson@hotmail.com", EmployeeId = 5 };

            modelBuilder.Entity<EMail>()
               .HasData(em1, em2, em3, em4, em5, em6, em7, em8, em9, em10, em11, em12, em13, em14)
               ;
            #endregion
            #region(Departments)
            var d1 = new Department()
            {
                Id = 1,
                Name = "Dairy",
                EmployeeId = e1.Id
            };
            var d2 = new Department()
            {
                Id = 2,
                Name = "Fruit",
                EmployeeId = e2.Id
            };
            var d3 = new Department()
            {
                Id = 3,
                Name = "Pantry",
                EmployeeId = e3.Id
            };
            var d4 = new Department()
            {
                Id = 4,
                Name = "Drinks",
                EmployeeId = e4.Id
            };
            var d5 = new Department()
            {
                Id = 5,
                Name = "Bread",
                EmployeeId = e5.Id
            };
            var d6 = new Department()
            {
                Id = 6,
                Name = "Meat",
                EmployeeId = e2.Id
            };
            modelBuilder.Entity<Department>()
                .HasData(d1, d2, d3, d4, d5, d6)
                ;

            #endregion
            #region("Products")
            var p1 = new Product()
            {
                Id = 1,
                Bar_Code = "D5905d216",
                Number_In_Store = 3,
                Name = "Milk",
                Exe_Date = DateTime.Parse("2021-05-23"),
                Price = 300,
                CampainId = 1,
                EmployeeId = 4,
                Date_Of_Last_Check = DateTime.Parse("2021-12-21")
            };
            var p2 = new Product()
            {
                Id = 2,
                Bar_Code = "D7502f749",
                Number_In_Store = 1,
                Name = "Cheese",
                Exe_Date = DateTime.Parse("2021-08-23"),
                Price = 400,
                CampainId = 4,
                EmployeeId = 2,
                Date_Of_Last_Check = DateTime.Parse("2021-12-26")
            };
            var p3 = new Product()
            {
                Id = 3,
                Bar_Code = "F2480d759",
                Number_In_Store = 3,
                Name = "Apple",
                Exe_Date = DateTime.Parse("2021-02-12"),
                Price = 400,
                CampainId = 3,
                EmployeeId = 1,
                Date_Of_Last_Check = DateTime.Parse("2021-12-25")
            };
            var p4 = new Product()
            {
                Id = 4,
                Bar_Code = "F1309p572",
                Number_In_Store = 9,
                Name = "Banana",
                Exe_Date = DateTime.Parse("2021-07-01"),
                Price = 600,
                CampainId = 2,
                EmployeeId = 4,
                Date_Of_Last_Check = DateTime.Parse("2021-12-12")
            };
            var p5 = new Product()
            {
                Id = 5,
                Bar_Code = "F6592d093",
                Number_In_Store = 3,
                Name = "Peach",
                Exe_Date = DateTime.Parse("2021-11-24"),
                Price = 200,
                CampainId = 1,
                EmployeeId = 5,
                Date_Of_Last_Check = DateTime.Parse("2021-12-15")
            };
            var p6 = new Product()
            {
                Id = 6,
                Bar_Code = "P1379b043",
                Number_In_Store = 1,
                Name = "Flour",
                Exe_Date = DateTime.Parse("2021-06-25"),
                Price = 800,
                CampainId = 3,
                EmployeeId = 5,
                Date_Of_Last_Check = DateTime.Parse("2021-12-22")
            };
            var p7 = new Product()
            {
                Id = 7,
                Bar_Code = "P9845p037",
                Number_In_Store = 2,
                Name = "Sugar",
                Exe_Date = DateTime.Parse("2021-02-26"),
                Price = 400,
                CampainId = 2,
                EmployeeId = 1,
                Date_Of_Last_Check = DateTime.Parse("2021-12-29")
            };
            var p8 = new Product()
            {
                Id = 8,
                Bar_Code = "D5754f521",
                Number_In_Store = 4,
                Name = "Juice",
                Exe_Date = DateTime.Parse("2021-08-25"),
                Price = 800,
                CampainId = 4,
                EmployeeId = 5,
                Date_Of_Last_Check = DateTime.Parse("2021-12-28")
            };
            var p9 = new Product()
            {
                Id = 9,
                Bar_Code = "D5467d807",
                Number_In_Store = 8,
                Name = "Tea",
                Exe_Date = DateTime.Parse("2021-06-17"),
                Price = 600,
                CampainId = 3,
                EmployeeId = 4,
                Date_Of_Last_Check = DateTime.Parse("2021-12-26")
            };
            var p10 = new Product()
            {
                Id = 10,
                Bar_Code = "B9087m314",
                Number_In_Store = 6,
                Name = "Toast",
                Exe_Date = DateTime.Parse("2021-05-18"),
                Price = 200,
                CampainId = 3,
                EmployeeId = 2,
                Date_Of_Last_Check = DateTime.Parse("2021-12-21")
            };
            var p11 = new Product()
            {
                Id = 11,
                Bar_Code = "B5454p879",
                Number_In_Store = 3,
                Name = "Biscut",
                Exe_Date = DateTime.Parse("2021-04-19"),
                Price = 400,
                EmployeeId = 3,
                Date_Of_Last_Check = DateTime.Parse("2021-12-15")
            };
            var p12 = new Product()
            {
                Id = 12,
                Bar_Code = "B6432m665",
                Number_In_Store = 3,
                Name = "Pudding",
                Exe_Date = DateTime.Parse("2021-09-16"),
                Price = 600,
                CampainId = 1,
                EmployeeId = 1,
                Date_Of_Last_Check = DateTime.Parse("2021-12-18")
            };
            var p13 = new Product()
            {
                Id = 13,
                Bar_Code = "M6367f485",
                Number_In_Store = 2,
                Name = "Sausages",
                Exe_Date = DateTime.Parse("2021-07-11"),
                Price = 400,
                EmployeeId = 5,
                Date_Of_Last_Check = DateTime.Parse("2021-12-11")
            };
            var p14 = new Product()
            {
                Id = 14,
                Bar_Code = "M7954d208",
                Number_In_Store = 4,
                Name = "Cruts",
                Exe_Date = DateTime.Parse("2021-08-14"),
                Price = 300,
                CampainId = 2,
                EmployeeId = 2,
                Date_Of_Last_Check = DateTime.Parse("2021-12-07")
            };
            var p15 = new Product()
            {
                Id = 15,
                Bar_Code = "M3213p656",
                Number_In_Store = 1,
                Name = "Chicken",
                Exe_Date = DateTime.Parse("2021-11-22"),
                Price = 200,
                EmployeeId = 3,
                Date_Of_Last_Check = DateTime.Parse("2021-12-09")
            };
            var p16 = new Product()
            {
                Id = 16,
                Bar_Code = "D1207d865",
                Number_In_Store = 4,
                Name = "Yogurt",
                Exe_Date = DateTime.Parse("2021-12-23"),
                Price = 600,
                List_Of_Ingredients = "Milk,Bacteria",
                EmployeeId = 3,
                Date_Of_Last_Check = DateTime.Parse("2021-12-04")
            };
            var p17 = new Product()
            {
                Id = 17,
                Bar_Code = "P3254m697",
                Number_In_Store = 3,
                Name = "Pasta",
                Exe_Date = DateTime.Parse("2021-09-27"),
                Price = 100,
                List_Of_Ingredients = "Durum,Flour",
                EmployeeId = 4,
                Date_Of_Last_Check = DateTime.Parse("2021-12-28")
            };
            var p18 = new Product()
            {
                Id = 18,
                Bar_Code = "D3252d375",
                Number_In_Store = 6,
                Name = "Coffee",
                Exe_Date = DateTime.Parse("2021-03-25"),
                Price = 800,
                List_Of_Ingredients = "Caffeine,Tannin,Oil,Carbohydrates",
                EmployeeId = 1,
                Date_Of_Last_Check = DateTime.Parse("2021-12-01")
            };
            var p19 = new Product()
            {
                Id = 19,
                Bar_Code = "D3252d624",
                Number_In_Store = 3,
                Name = "Butter",
                Exe_Date = DateTime.Parse("2021-08-25"),
                Price = 150,
                EmployeeId = 3,
                Date_Of_Last_Check = DateTime.Parse("2021-12-01")
            };
            var p20 = new Product()
            {
                Id = 20,
                Bar_Code = "D6248d375",
                Number_In_Store = 3,
                Name = "Bagel",
                Exe_Date = DateTime.Parse("2021-07-25"),
                Price = 300,
                EmployeeId = 2,
                Date_Of_Last_Check = DateTime.Parse("2021-12-21")
            };
            var p21 = new Product()
            {
                Id = 21,
                Bar_Code = "D5257d375",
                Number_In_Store = 2,
                Name = "Crossiant",
                Exe_Date = DateTime.Parse("2021-04-25"),
                Price = 200,
                EmployeeId = 1,
                Date_Of_Last_Check = DateTime.Parse("2021-12-11")
            };
            var p22 = new Product()
            {
                Id = 22,
                Bar_Code = "D2135d375",
                Number_In_Store = 12,
                Name = "Baguette",
                Exe_Date = DateTime.Parse("2021-11-25"),
                Price = 100,
                EmployeeId = 2,
                Date_Of_Last_Check = DateTime.Parse("2021-12-12")
            };
            modelBuilder.Entity<Product>()
                .HasData(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22)
                ;
            #endregion
            //Campain
            var c1 = new Campain() { Id = 1, Price_Drop = 10 };
            var c2 = new Campain() { Id = 2, Price_Drop = 15 };
            var c3 = new Campain() { Id = 3, Price_Drop = 25 };
            var c4 = new Campain() { Id = 4, Price_Drop = 50 };
            modelBuilder.Entity<Campain>()
                .HasData(c1, c2, c3, c4)
                ;

            //Sort Products on Departments
            modelBuilder.Entity<DepartmentProduct>()
                .HasData(
                    new { ProductsId = 1, DepartmentsId = 1 },
                    new { ProductsId = 1, DepartmentsId = 4 },
                    new { ProductsId = 2, DepartmentsId = 1 },
                    new { ProductsId = 3, DepartmentsId = 2 },
                    new { ProductsId = 3, DepartmentsId = 4 },
                    new { ProductsId = 4, DepartmentsId = 2 },
                    new { ProductsId = 4, DepartmentsId = 4 },
                    new { ProductsId = 5, DepartmentsId = 4 },
                    new { ProductsId = 5, DepartmentsId = 2 },
                    new { ProductsId = 6, DepartmentsId = 3 },
                    new { ProductsId = 7, DepartmentsId = 3 },
                    new { ProductsId = 8, DepartmentsId = 4 },
                    new { ProductsId = 9, DepartmentsId = 4 },
                    new { ProductsId = 9, DepartmentsId = 3 },
                    new { ProductsId = 10, DepartmentsId = 5 },
                    new { ProductsId = 10, DepartmentsId = 3 },
                    new { ProductsId = 11, DepartmentsId = 5 },
                    new { ProductsId = 12, DepartmentsId = 6 },
                    new { ProductsId = 13, DepartmentsId = 6 },
                    new { ProductsId = 14, DepartmentsId = 5 },
                    new { ProductsId = 15, DepartmentsId = 6 },
                    new { ProductsId = 16, DepartmentsId = 1 },
                    new { ProductsId = 17, DepartmentsId = 3 },
                    new { ProductsId = 18, DepartmentsId = 4 },
                    new { ProductsId = 18, DepartmentsId = 3 },
                    new { ProductsId = 19, DepartmentsId = 1 },
                    new { ProductsId = 19, DepartmentsId = 3 },
                    new { ProductsId = 20, DepartmentsId = 3 },
                    new { ProductsId = 20, DepartmentsId = 5 },
                    new { ProductsId = 21, DepartmentsId = 3 },
                    new { ProductsId = 21, DepartmentsId = 5 },
                    new { ProductsId = 22, DepartmentsId = 3 },
                    new { ProductsId = 22, DepartmentsId = 5 }
                   );
        }
    }
}
