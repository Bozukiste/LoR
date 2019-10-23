using Microsoft.EntityFrameworkCore.Migrations;

namespace LoRAPI.Migrations
{
    public partial class LorAPIDataCardContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiotId = table.Column<string>(nullable: true),
                    RegionRef = table.Column<int>(nullable: false),
                    Attack = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Health = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    FlavorText = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    KeywordsRefs = table.Column<string>(nullable: true),
                    SpellSpeed = table.Column<int>(nullable: true),
                    SubType = table.Column<int>(nullable: true),
                    SuperType = table.Column<int>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    Collectable = table.Column<bool>(nullable: false),
                    CardVisualLink = table.Column<string>(nullable: true),
                    FullArtworkLink = table.Column<string>(nullable: true),
                    Legacy = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
