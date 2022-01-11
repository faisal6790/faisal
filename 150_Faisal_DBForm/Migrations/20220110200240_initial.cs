using Microsoft.EntityFrameworkCore.Migrations;

namespace _150_Faisal_DBForm.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customerdepartment",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "email",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "contacts");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "contacts",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "message",
                table: "contacts",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "contacts",
                newName: "description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "contacts",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "contacts",
                newName: "message");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "contacts",
                newName: "lastname");

            migrationBuilder.AddColumn<string>(
                name: "customerdepartment",
                table: "contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "contacts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
