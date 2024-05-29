using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    public partial class _2imagesonlocationid1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "LandlordId", "LocationId", "Url" },
                values: new object[] { 2, true, null, 1, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/2011_Berat%2C_Cerkiew_%C5%9Bw._Teodora.JPG/1024px-2011_Berat%2C_Cerkiew_%C5%9Bw._Teodora.JPG" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
