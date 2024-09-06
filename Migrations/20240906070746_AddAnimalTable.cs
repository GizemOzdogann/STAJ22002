using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmManager.Migrations
{
    /// <inheritdoc />
    public partial class AddAnimalTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Animals",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Age = table.Column<int>(type: "int", nullable: false),
            //        LifeTick = table.Column<int>(type: "int", nullable: false),
            //        ProductTick = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Animals", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
            name: "LifeTick",
            table: "Animals",
            nullable: false,
            defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductTick",
                table: "Animals",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
