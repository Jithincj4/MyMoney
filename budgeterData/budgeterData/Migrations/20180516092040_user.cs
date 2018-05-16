using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace budgeterData.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserRealName",
                table: "users",
                newName: "firstname");
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "users",
                newName: "id");
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "firstname",
                table: "users",
                newName: "UserRealName");
            migrationBuilder.RenameColumn(
             name: "id",
             table: "users",
             newName: "UserId");
        }
    }
}
