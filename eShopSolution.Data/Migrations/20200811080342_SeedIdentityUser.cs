using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 11, 15, 3, 41, 141, DateTimeKind.Local).AddTicks(6364),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 8, 11, 14, 45, 28, 477, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("55fe3cb9-576f-47c7-b5a9-ee5ec1259c63"), "13e63d7b-fdd7-4a2e-acce-034a7d29a94d", "Administrator Role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("55fe3cb9-576f-47c7-b5a9-ee5ec1259c63"), new Guid("f2199940-eabc-4a28-9856-c8456b5326a8") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirtName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f2199940-eabc-4a28-9856-c8456b5326a8"), 0, "455e153e-ab1f-46be-858c-e2ab072ab830", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dangphuocduy@gmail.com", true, "Duy", "Dang Phuoc", false, null, "dangphuocduy@gmail.com", "admin", "AQAAAAEAACcQAAAAEN7Cqw0NC8m9J1za4Odj3ipatF3+OtUdawcStc3X1o4TS/pULB2qslnWhbKUY8x1Tg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 8, 11, 15, 3, 41, 179, DateTimeKind.Local).AddTicks(913));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("55fe3cb9-576f-47c7-b5a9-ee5ec1259c63"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("55fe3cb9-576f-47c7-b5a9-ee5ec1259c63"), new Guid("f2199940-eabc-4a28-9856-c8456b5326a8") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2199940-eabc-4a28-9856-c8456b5326a8"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 11, 14, 45, 28, 477, DateTimeKind.Local).AddTicks(2535),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 11, 15, 3, 41, 141, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 8, 11, 14, 45, 28, 520, DateTimeKind.Local).AddTicks(4480));
        }
    }
}
