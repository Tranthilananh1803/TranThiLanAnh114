using Microsoft.EntityFrameworkCore.Migrations;

namespace TranThiLanAnh114.Migrations
{
    public partial class Create_Table_Universitys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Universitys",
                columns: table => new
                {
                    UniversityID = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    UniversityName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universitys", x => x.UniversityID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Universitys");
        }
    }
}
