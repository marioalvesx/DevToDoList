using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevToDoList.API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DevTodos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDone = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevTodos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevTodoReactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPositive = table.Column<bool>(type: "bit", nullable: false),
                    DevTodoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevTodoReactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DevTodoReactions_DevTodos_DevTodoId",
                        column: x => x.DevTodoId,
                        principalTable: "DevTodos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DevTodoReactions_DevTodoId",
                table: "DevTodoReactions",
                column: "DevTodoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevTodoReactions");

            migrationBuilder.DropTable(
                name: "DevTodos");
        }
    }
}
