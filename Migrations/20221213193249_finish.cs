using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesCampaign.Migrations
{
    /// <inheritdoc />
    public partial class finish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emerald",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountBalance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emerald", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Town",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TownName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampaignId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Town", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Town_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaign",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Town_CampaignId",
                table: "Town",
                column: "CampaignId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emerald");

            migrationBuilder.DropTable(
                name: "Town");
        }
    }
}
