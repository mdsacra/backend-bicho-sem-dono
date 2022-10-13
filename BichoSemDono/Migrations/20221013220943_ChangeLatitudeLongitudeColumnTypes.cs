using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BichoSemDono.Migrations
{
    /// <inheritdoc />
    public partial class ChangeLatitudeLongitudeColumnTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE \"OwnerlessPetPosts\" ALTER COLUMN \"Localization_Longitude\" TYPE double precision USING (\"Localization_Longitude\"::double precision);");
            
            migrationBuilder.Sql("ALTER TABLE \"OwnerlessPetPosts\" ALTER COLUMN \"Localization_Latitude\" TYPE double precision USING (\"Localization_Latitude\"::double precision);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE \"OwnerlessPetPosts\" ALTER COLUMN \"Localization_Longitude\" TYPE text USING (\"Localization_Longitude\"::text);");

            migrationBuilder.Sql("ALTER TABLE \"OwnerlessPetPosts\" ALTER COLUMN \"Localization_Latitude\" TYPE text USING (\"Localization_Latitude\"::text);");
        }
    }
}
