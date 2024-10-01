using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMvc.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MouMou");

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    CCCD = table.Column<string>(type: "TEXT", nullable: false),
                    HoTen = table.Column<string>(type: "TEXT", nullable: false),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.CCCD);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.CreateTable(
                name: "MouMou",
                columns: table => new
                {
                    MouId = table.Column<string>(type: "TEXT", nullable: false),
                    MouName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MouMou", x => x.MouId);
                });
        }
    }
}
