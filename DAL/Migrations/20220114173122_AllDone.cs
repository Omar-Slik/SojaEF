using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class AllDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price_Drop = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person_Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EMail",
                columns: table => new
                {
                    Value = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMail", x => new { x.EmployeeId, x.Value });
                    table.ForeignKey(
                        name: "FK_EMail_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    Value = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => new { x.EmployeeId, x.Value });
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bar_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number_In_Store = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    List_Of_Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Exe_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CampainId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Date_Of_Last_Check = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Campains_CampainId",
                        column: x => x.CampainId,
                        principalTable: "Campains",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentsProducts",
                columns: table => new
                {
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentsProducts", x => new { x.ProductsId, x.DepartmentsId });
                    table.ForeignKey(
                        name: "FK_DepartmentsProducts_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DepartmentsProducts_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Campains",
                columns: new[] { "Id", "Price_Drop" },
                values: new object[,]
                {
                    { 1, 10.0 },
                    { 2, 15.0 },
                    { 3, 25.0 },
                    { 4, 50.0 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "EmployeeId", "First_Name", "Last_Name", "Person_Number" },
                values: new object[,]
                {
                    { 1, null, "Omar", "slik", "9004072142" },
                    { 2, null, "Ulf", "Hedberg", "9407247294" },
                    { 3, null, "Agda", "Erikson", "9112314292" },
                    { 4, null, "Samauel", "Norlund", "9506053255" },
                    { 5, null, "Erik", "Anderson", "8801013287" },
                    { 6, null, "Pelle", "Haglund", "8909034212" },
                    { 7, null, "Albin", "Eklund", "9906024632" },
                    { 8, null, "Victoria", "Husak", "9007068576" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "EmployeeId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Dairy" },
                    { 2, 2, "Fruit" },
                    { 3, 3, "Pantry" },
                    { 4, 4, "Drinks" },
                    { 5, 5, "Bread" },
                    { 6, 2, "Meat" }
                });

            migrationBuilder.InsertData(
                table: "EMail",
                columns: new[] { "EmployeeId", "Value" },
                values: new object[,]
                {
                    { 1, "omar.slik@gmail.com" },
                    { 1, "omar.slik@hotmail.com" },
                    { 1, "omar.slik@outlook.com" },
                    { 1, "omar.slik@studerande-skys.com" },
                    { 2, "Adham.samauelson@outlook.com" },
                    { 3, "Agda.erikson@outlook.com" },
                    { 4, "Samauel.Norlund@outlook.com" },
                    { 5, "erik.anderson@hotmail.com" },
                    { 5, "erik.anderson@outlook.com" },
                    { 6, "pelle.haglund@outlook.com" },
                    { 7, "albin.eklund@gmail.com" },
                    { 7, "albin.eklund@outlook.com" },
                    { 8, "victoria.Husak@hotmail.com" },
                    { 8, "victoria.Husak@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumber",
                columns: new[] { "EmployeeId", "Value" },
                values: new object[,]
                {
                    { 1, "0753473782" },
                    { 1, "0790763259" },
                    { 2, "0753161642" },
                    { 2, "0753982342" },
                    { 3, "0702397109" },
                    { 4, "0742315214" },
                    { 5, "0709523021" },
                    { 6, "0767415941" },
                    { 7, "0743268453" },
                    { 7, "0753982342" },
                    { 8, "0790765689" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Bar_Code", "CampainId", "Date_Of_Last_Check", "EmployeeId", "Exe_Date", "List_Of_Ingredients", "Name", "Number_In_Store", "Price" },
                values: new object[,]
                {
                    { 1, "D5905d216", 1, new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Milk", 3, 300 },
                    { 2, "D7502f749", 4, new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cheese", 1, 400 },
                    { 3, "F2480d759", 3, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Apple", 3, 400 },
                    { 4, "F1309p572", 2, new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Banana", 9, 600 },
                    { 5, "F6592d093", 1, new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Peach", 3, 200 },
                    { 6, "P1379b043", 3, new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Flour", 1, 800 },
                    { 7, "P9845p037", 2, new DateTime(2021, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sugar", 2, 400 },
                    { 8, "D5754f521", 4, new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Juice", 4, 800 },
                    { 9, "D5467d807", 3, new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tea", 8, 600 },
                    { 10, "B9087m314", 3, new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Toast", 6, 200 },
                    { 11, "B5454p879", null, new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Biscut", 3, 400 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Bar_Code", "CampainId", "Date_Of_Last_Check", "EmployeeId", "Exe_Date", "List_Of_Ingredients", "Name", "Number_In_Store", "Price" },
                values: new object[,]
                {
                    { 12, "B6432m665", 1, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pudding", 3, 600 },
                    { 13, "M6367f485", null, new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sausages", 2, 400 },
                    { 14, "M7954d208", 2, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cruts", 4, 300 },
                    { 15, "M3213p656", null, new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chicken", 1, 200 },
                    { 16, "D1207d865", null, new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk,Bacteria", "Yogurt", 4, 600 },
                    { 17, "P3254m697", null, new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Durum,Flour", "Pasta", 3, 100 },
                    { 18, "D3252d375", null, new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caffeine,Tannin,Oil,Carbohydrates", "Coffee", 6, 800 },
                    { 19, "D3252d624", null, new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Butter", 3, 150 },
                    { 20, "D6248d375", null, new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bagel", 3, 300 },
                    { 21, "D5257d375", null, new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Crossiant", 2, 200 },
                    { 22, "D2135d375", null, new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Baguette", 12, 100 }
                });

            migrationBuilder.InsertData(
                table: "DepartmentsProducts",
                columns: new[] { "DepartmentsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 4, 3 },
                    { 2, 4 },
                    { 4, 4 },
                    { 2, 5 },
                    { 4, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 8 },
                    { 3, 9 },
                    { 4, 9 },
                    { 3, 10 },
                    { 5, 10 },
                    { 5, 11 },
                    { 6, 12 },
                    { 6, 13 },
                    { 5, 14 },
                    { 6, 15 },
                    { 1, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 4, 18 },
                    { 1, 19 },
                    { 3, 19 },
                    { 3, 20 },
                    { 5, 20 },
                    { 3, 21 },
                    { 5, 21 },
                    { 3, 22 },
                    { 5, 22 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsProducts_DepartmentsId",
                table: "DepartmentsProducts",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CampainId",
                table: "Products",
                column: "CampainId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_EmployeeId",
                table: "Products",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentsProducts");

            migrationBuilder.DropTable(
                name: "EMail");

            migrationBuilder.DropTable(
                name: "PhoneNumber");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Campains");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
