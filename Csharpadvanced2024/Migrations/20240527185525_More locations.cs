using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    public partial class Morelocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvatarId",
                table: "Landlords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Description", "Features", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[,]
                {
                    { 1, "Dit is de eerste locatie", 0, 10, 300f, 5, "Mooie locatie", "Locatie nr. 1", 1 },
                    { 2, "Dit is de tweede locatie", 0, 10, 300f, 5, "Mooie locatie", "Locatie nr. 2", 1 },
                    { 5, "Dit is de vijfde locatie", 0, 10, 300f, 5, "Mooie locatie", "Locatie nr. 5", 1 },
                    { 6, "Dit is de zesde locatie", 0, 10, 300f, 5, "Mooie locatie", "Locatie nr. 6", 1 },
                    { 7, "Dit is de zevende locatie", 0, 10, 300f, 5, "Mooie locatie", "Locatie nr. 7", 1 },
                    { 8, "Dit is de achste locatie", 0, 10, 300f, 5, "Mooie locatie", "Locatie nr. 8", 1 },
                    { 9, "Dit is de negende locatie", 0, 10, 300f, 5, "Mooie locatie", "Locatie nr. 9", 1 },
                    { 19, "Dit is de tiende locatie", 0, 10, 300f, 5, "Mooie locatie", "Locatie nr. 19", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Landlords_AvatarId",
                table: "Landlords",
                column: "AvatarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Landlords_Images_AvatarId",
                table: "Landlords",
                column: "AvatarId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landlords_Images_AvatarId",
                table: "Landlords");

            migrationBuilder.DropIndex(
                name: "IX_Landlords_AvatarId",
                table: "Landlords");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DropColumn(
                name: "AvatarId",
                table: "Landlords");
        }
    }
}
