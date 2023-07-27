using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingListAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddProductPropertyIsBought : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsBought",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                comment: "Used to show user if product has been purchased or not",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldComment: "Used to show user if product has been purchased or not");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsBought",
                table: "Products",
                type: "TEXT",
                nullable: false,
                comment: "Used to show user if product has been purchased or not",
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldComment: "Used to show user if product has been purchased or not");
        }
    }
}
