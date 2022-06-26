using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.LimeZander.Persistence.Migrations
{
    public partial class qty_prop_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SoldQuantity",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoldQuantity",
                table: "Products");
        }
    }
}
