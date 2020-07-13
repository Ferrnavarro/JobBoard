using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobBoard.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ExpiresAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedAt", "Description", "ExpiresAt", "Title" },
                values: new object[,]
                {
                    { new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), new DateTime(2020, 7, 13, 15, 46, 39, 992, DateTimeKind.Local).AddTicks(6293), "We are looking for a Python Web Developer responsible for managing the interchange of data between the server and the users.", new DateTime(2020, 7, 28, 15, 46, 39, 994, DateTimeKind.Local).AddTicks(2106), "Python Developer" },
                    { new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), new DateTime(2020, 7, 13, 15, 46, 39, 994, DateTimeKind.Local).AddTicks(2934), "Architect, build and maintain excellent React Native applications with clean code.", new DateTime(2020, 7, 28, 15, 46, 39, 994, DateTimeKind.Local).AddTicks(2951), "React Native Developer" },
                    { new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), new DateTime(2020, 7, 13, 15, 46, 39, 994, DateTimeKind.Local).AddTicks(2969), "Our enterprise-level client is looking for a junior to mid-level Product Designer to assist with the launch of several pilots.", new DateTime(2020, 7, 28, 15, 46, 39, 994, DateTimeKind.Local).AddTicks(2970), "UX Designer" },
                    { new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"), new DateTime(2020, 7, 13, 15, 46, 39, 994, DateTimeKind.Local).AddTicks(2975), "Analyze current technology utilized within the company and develop steps and processes to improve and expand upon them.", new DateTime(2020, 7, 28, 15, 46, 39, 994, DateTimeKind.Local).AddTicks(2977), "DevOps engineer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
