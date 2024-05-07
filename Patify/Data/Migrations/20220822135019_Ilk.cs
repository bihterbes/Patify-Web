using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Patify.Data.Migrations
{
    public partial class Ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    ArticleHeader = table.Column<string>(nullable: true),
                    ArticlePhoto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSurname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Advert",
                columns: table => new
                {
                    AdvertId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    AnimalName = table.Column<string>(nullable: true),
                    AnimalAge = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    AnimalRace = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    SizeOfAnimal = table.Column<int>(nullable: true),
                    FromWho = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advert", x => x.AdvertId);
                    table.ForeignKey(
                        name: "FK_Advert_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advert_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotosId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertId = table.Column<int>(nullable: false)
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
                name: "IX_Advert_CategoryId",
                table: "Advert",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Advert_CityId",
                table: "Advert",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AdvertId",
                table: "Photos",
                column: "AdvertId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Advert");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");
        }
    }
}
