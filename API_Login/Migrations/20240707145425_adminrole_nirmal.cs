using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Login.Migrations
{
    /// <inheritdoc />
    public partial class adminrole_nirmal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedBy",
                table: "LoginUser",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "LoginUser",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RoleKey",
                table: "LoginUser",
                type: "BIGINT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdminRole",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "varchar(250)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRole", x => x.RoleId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoginUser_RoleId",
                table: "LoginUser",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoginUser_AdminRole_RoleId",
                table: "LoginUser",
                column: "RoleId",
                principalTable: "AdminRole",
                principalColumn: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginUser_AdminRole_RoleId",
                table: "LoginUser");

            migrationBuilder.DropTable(
                name: "AdminRole");

            migrationBuilder.DropIndex(
                name: "IX_LoginUser_RoleId",
                table: "LoginUser");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "LoginUser");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "LoginUser");

            migrationBuilder.DropColumn(
                name: "RoleKey",
                table: "LoginUser");
        }
    }
}
