using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClienteCRUD.Migrations
{
    /// <inheritdoc />
    public partial class DB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Users",
                type: "character varying(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 11);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CPF",
                table: "Users",
                type: "integer",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(11)",
                oldMaxLength: 11);
        }
    }
}
