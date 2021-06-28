using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class seedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddedAt", "Address", "CreatedAt", "Email", "ModifiedAt", "Name", "PhoneNumber", "UserName" },
                values: new object[] { new Guid("11223344-5566-7788-99aa-bbccddeeff00"), null, null, new DateTime(2021, 6, 29, 0, 53, 48, 989, DateTimeKind.Local).AddTicks(8170), "Mirna@mail.com", null, "Mirna", "01000000", "Mirna" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddedAt", "Address", "CreatedAt", "Email", "ModifiedAt", "Name", "PhoneNumber", "UserName" },
                values: new object[] { new Guid("12223344-2566-7788-99aa-bbccddeeff00"), null, null, new DateTime(2021, 6, 29, 0, 53, 48, 991, DateTimeKind.Local).AddTicks(1820), "sam@mail.com", null, "Sam", "01000000", "Sam" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddedAt", "Address", "CreatedAt", "Email", "ModifiedAt", "Name", "PhoneNumber", "UserName" },
                values: new object[] { new Guid("13223344-3566-7788-99aa-bbccddeeff00"), null, null, new DateTime(2021, 6, 29, 0, 53, 48, 991, DateTimeKind.Local).AddTicks(1853), "John@mail.com", null, "John", "01000000", "John" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11223344-5566-7788-99aa-bbccddeeff00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12223344-2566-7788-99aa-bbccddeeff00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13223344-3566-7788-99aa-bbccddeeff00"));
        }
    }
}
