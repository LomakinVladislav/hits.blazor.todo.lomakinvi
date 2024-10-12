using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "CreateDate", "Description", "FinishDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 12, 16, 44, 47, 713, DateTimeKind.Local).AddTicks(875), "Описание задачи 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Задача 1" },
                    { 2, new DateTime(2024, 10, 12, 16, 44, 47, 713, DateTimeKind.Local).AddTicks(889), "Описание задачи 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Задача 2" },
                    { 3, new DateTime(2024, 10, 12, 16, 44, 47, 713, DateTimeKind.Local).AddTicks(966), "Описание задачи 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Задача 3" },
                    { 4, new DateTime(2024, 10, 12, 16, 44, 47, 713, DateTimeKind.Local).AddTicks(967), "Описание задачи 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Задача 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");
        }
    }
}
