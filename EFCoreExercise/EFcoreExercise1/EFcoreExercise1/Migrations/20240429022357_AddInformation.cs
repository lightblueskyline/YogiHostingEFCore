using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcoreExercise1.Migrations
{
    /// <inheritdoc />
    public partial class AddInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Information",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    License = table.Column<string>(type: "TEXT", nullable: true),
                    Establshied = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Revenue = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Information");
        }
    }
}
