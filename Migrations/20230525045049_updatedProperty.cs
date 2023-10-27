using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullStackApi.Migrations
{
    /// <inheritdoc />
    public partial class updatedProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Img",
                table: "Employees",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "varbinary(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Img",
                table: "Employees",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(string),
                oldType: "varbinary(max)",
                oldNullable: true);
        }
    }
}
