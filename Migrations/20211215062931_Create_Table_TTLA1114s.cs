using Microsoft.EntityFrameworkCore.Migrations;

namespace TranThiLanAnh114.Migrations
{
    public partial class Create_Table_TTLA1114s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TTLA1114s",
                columns: table => new
                {
                    TTLAId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    TTLAName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    TTLAGener = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TTLA1114s", x => x.TTLAId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TTLA1114s");
        }
    }
}
