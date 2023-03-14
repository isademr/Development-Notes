using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentRestAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "dmrisa05@gmail.com", "İsa", 0, "Demir", "Images/Demir.png" },
                    { 2, new DateTime(1993, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "aliveli@gmail.com", "Ali", 0, "Veli", "Images/Veli.png" },
                    { 3, new DateTime(1987, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Chris@gmail.com", "Christina", 1, "Frost", "Images/Christina.png" },
                    { 4, new DateTime(1982, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Rachel@gmail.com", "Rachel", 1, "Stone", "Images/Rachel.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
