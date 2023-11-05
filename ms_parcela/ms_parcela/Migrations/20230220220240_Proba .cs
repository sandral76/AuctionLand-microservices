using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace msparcela.Migrations
{
    /// <inheritdoc />
    public partial class Proba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KatastarskaOpstinas",
                keyColumn: "brojKatastarskeOpstine",
                keyValue: new Guid("c483e893-eb84-4f5b-93ea-b73050556570"));

            migrationBuilder.DeleteData(
                table: "KatastarskaOpstinas",
                keyColumn: "brojKatastarskeOpstine",
                keyValue: new Guid("f317cb93-c130-4258-bc47-9542bfc349f5"));

            migrationBuilder.DeleteData(
                table: "Zonas",
                keyColumn: "zonaID",
                keyValue: new Guid("3558643f-1476-4d2c-9550-456fc50334ca"));

            migrationBuilder.DeleteData(
                table: "Zonas",
                keyColumn: "zonaID",
                keyValue: new Guid("8176dcc9-6563-4e20-8c56-f110b1ee98ab"));

            migrationBuilder.CreateTable(
                name: "DeoParceles",
                columns: table => new
                {
                    deoParceleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    redniBrojDelaParcele = table.Column<int>(type: "int", nullable: false),
                    povrsinaDelaParcele = table.Column<int>(type: "int", nullable: false),
                    brojKatastraskaOpstina = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    brojParcele = table.Column<int>(type: "int", nullable: false),
                    NadmetanjeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeoParceles", x => x.deoParceleID);
                });

            migrationBuilder.InsertData(
                table: "DeoParceles",
                columns: new[] { "deoParceleID", "NadmetanjeId", "brojKatastraskaOpstina", "brojParcele", "povrsinaDelaParcele", "redniBrojDelaParcele"},
                values: new object[,]
                {
                    { new Guid("68981084-b4a6-4564-bb69-7e2f24e5da8a"), new Guid("1f8fad5b-d9cb-469f-a165-70867728950e"), new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"), 1, 200, 3},
                    { new Guid("765db74b-83ca-42d9-bc5b-9cd42b856382"), new Guid("128fad5b-d9cb-469f-a165-70867728950e"), new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"), 1, 200, 4}
                });

            migrationBuilder.InsertData(
                table: "KatastarskaOpstinas",
                columns: new[] { "brojKatastarskeOpstine", "nazivKatastarskeOpstine" },
                values: new object[,]
                {
                    { new Guid("92c9314c-6f9b-41c7-b0d5-4241887bc3d5"), "Bajmok" },
                    { new Guid("a753ea75-c9ca-4ed6-bdf9-086669028d8d"), "Cantavir" }
                });

            migrationBuilder.InsertData(
                table: "Zonas",
                columns: new[] { "zonaID", "brojZona" },
                values: new object[,]
                {
                    { new Guid("3a64f694-e6de-4338-8b7a-f140c4004d6c"), "zona3" },
                    { new Guid("3e3ac7f4-3f7f-470a-95d0-1bf84c2584af"), "zona4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeoParceles");

            migrationBuilder.DeleteData(
                table: "KatastarskaOpstinas",
                keyColumn: "brojKatastarskeOpstine",
                keyValue: new Guid("92c9314c-6f9b-41c7-b0d5-4241887bc3d5"));

            migrationBuilder.DeleteData(
                table: "KatastarskaOpstinas",
                keyColumn: "brojKatastarskeOpstine",
                keyValue: new Guid("a753ea75-c9ca-4ed6-bdf9-086669028d8d"));

            migrationBuilder.DeleteData(
                table: "Zonas",
                keyColumn: "zonaID",
                keyValue: new Guid("3a64f694-e6de-4338-8b7a-f140c4004d6c"));

            migrationBuilder.DeleteData(
                table: "Zonas",
                keyColumn: "zonaID",
                keyValue: new Guid("3e3ac7f4-3f7f-470a-95d0-1bf84c2584af"));

            migrationBuilder.InsertData(
                table: "KatastarskaOpstinas",
                columns: new[] { "brojKatastarskeOpstine", "nazivKatastarskeOpstine" },
                values: new object[,]
                {
                    { new Guid("c483e893-eb84-4f5b-93ea-b73050556570"), "Bajmok" },
                    { new Guid("f317cb93-c130-4258-bc47-9542bfc349f5"), "Cantavir" }
                });

            migrationBuilder.InsertData(
                table: "Zonas",
                columns: new[] { "zonaID", "brojZona" },
                values: new object[,]
                {
                    { new Guid("3558643f-1476-4d2c-9550-456fc50334ca"), "zona4" },
                    { new Guid("8176dcc9-6563-4e20-8c56-f110b1ee98ab"), "zona3" }
                });
        }
    }
}
