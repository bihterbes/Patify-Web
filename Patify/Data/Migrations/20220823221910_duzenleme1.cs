using Microsoft.EntityFrameworkCore.Migrations;

namespace Patify.Data.Migrations
{
    public partial class duzenleme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Advert",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Advert");

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotosId);
                    table.ForeignKey(
                        name: "FK_Photos_Advert_AdvertId",
                        column: x => x.AdvertId,
                        principalTable: "Advert",
                        principalColumn: "AdvertId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AdvertId",
                table: "Photos",
                column: "AdvertId");
        }
    }
}
