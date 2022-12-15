using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BichoSemDono.Migrations
{
    /// <inheritdoc />
    public partial class AddAdressLocalizationColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Localization_Address",
                table: "OwnerlessPetPosts",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Localization_Address",
                table: "OwnerlessPetPosts");
        }
    }
}
