using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    public partial class addedlandlords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landlords_Images_AvatarId",
                table: "Landlords");

            migrationBuilder.DropIndex(
                name: "IX_Landlords_AvatarId",
                table: "Landlords");

            migrationBuilder.DropColumn(
                name: "AvatarId",
                table: "Landlords");

            migrationBuilder.AddColumn<int>(
                name: "LandlordId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 1, 55, "John", "Doe" });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 2, 40, "Henk", "Pieters" });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 3, 36, "Jan", "Hollands" });

            migrationBuilder.CreateIndex(
                name: "IX_Images_LandlordId",
                table: "Images",
                column: "LandlordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Landlords_LandlordId",
                table: "Images",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Landlords_LandlordId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_LandlordId",
                table: "Images");

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "LandlordId",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "AvatarId",
                table: "Landlords",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
