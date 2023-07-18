using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaPan.DataAccessLayer.Migrations
{
    public partial class add_outteam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OurTeams",
                columns: table => new
                {
                    OurTeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OurTeamName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurTeamSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurTeamTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurTeamFacebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurTeamTwitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurTeamImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurTeamStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurTeams", x => x.OurTeamId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OurTeams");
        }
    }
}
