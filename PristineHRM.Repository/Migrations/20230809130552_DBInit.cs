using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PristineHRM.Repository.Migrations
{
    /// <inheritdoc />
    public partial class DBInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Emplyees");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Emplyees",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Emplyees",
                newName: "empImage");

            migrationBuilder.AddColumn<string>(
                name: "empAddressLine1",
                table: "Emplyees",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "empAddressLine2",
                table: "Emplyees",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "empAddressLine3",
                table: "Emplyees",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "empDateOfJoin",
                table: "Emplyees",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "empName",
                table: "Emplyees",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "empNo",
                table: "Emplyees",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "empStatus",
                table: "Emplyees",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Emplyees_empNo",
                table: "Emplyees",
                column: "empNo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Emplyees_empNo",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "empAddressLine1",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "empAddressLine2",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "empAddressLine3",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "empDateOfJoin",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "empName",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "empNo",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "empStatus",
                table: "Emplyees");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Emplyees",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "empImage",
                table: "Emplyees",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Emplyees",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
