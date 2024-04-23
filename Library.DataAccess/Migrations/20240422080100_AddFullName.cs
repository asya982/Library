using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFullName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("109fd595-7d14-4c96-8604-b68e5deb74ac"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("12799149-ed27-4f34-b5d2-8e8cf108d62d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("157ba977-3695-4ade-ad17-c54005bf6fb4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("28288c1f-12a1-4239-9583-ee4dc5013f5d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3557a5ce-39ca-40e1-aa78-cba0aa50ca6a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("362e51c1-ef4c-4d8e-9887-d57910e1e046"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4934509f-46ea-4d6d-9f07-3decbcd51d43"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4b90b5b4-cd4f-4a82-a5c3-13d649523a00"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6b1524bc-a763-491c-a844-a507057ca17a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("74fbedd6-7d11-4923-80d9-ba2498811396"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("772f3779-657e-45e2-bbbe-55b90d89d18f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7d2575ac-19e0-4ace-adf3-da6c851a13f3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8e19f8c1-919e-4656-9b19-07127110f69d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a13af236-a938-48be-a97d-508c4835105b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a1ee404c-7e93-4d38-bb4e-42359f4f02f0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b957757d-9dd5-486e-9621-7257474c7dd0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c52108a7-1e21-44d8-9884-bba300489c78"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f54c540b-4446-4a65-bc13-ae3b4b751ef7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f7dcd500-c9c1-4693-8bec-2c8cad3c7483"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fac15666-77d0-4422-ab48-f080dfdab36e"));

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("002d18e8-a77f-45f0-b2e5-ce5cf0685b5d"), "Science" },
                    { new Guid("09a9889a-b209-4d49-9c51-4927106253be"), "Science Fiction" },
                    { new Guid("1a826024-7f94-4985-b31d-4585530d5f95"), "Self-Help" },
                    { new Guid("41546cd8-4401-481f-8db3-d79bd515155c"), "Historical Fiction" },
                    { new Guid("5ab219b8-03f9-465c-8b74-2fcdc3ebdb8a"), "Graphic Novels" },
                    { new Guid("6364f162-e83f-4bf2-aee1-97081407cc62"), "Mystery" },
                    { new Guid("6c34e5a9-843f-4d30-b337-549afe3d3afd"), "Memoir" },
                    { new Guid("73d03ade-099c-41ac-87b8-4c79c30e5562"), "Fantasy" },
                    { new Guid("834b21e2-73ea-4c7a-b6cb-3bda099bd662"), "Biography" },
                    { new Guid("859987ac-918f-434b-9a42-c1632d91b6b6"), "Non-Fiction" },
                    { new Guid("9d9e8f75-70f0-4c5b-8fde-6deea4a120cb"), "Young Adult" },
                    { new Guid("a536a615-6d6d-46c3-a1dd-16fc4834dc3e"), "Adventure" },
                    { new Guid("ac4c425c-ffaa-487c-a185-65b210ed1863"), "Cookbooks" },
                    { new Guid("b08ce52a-29a8-4f5c-850a-0ea4c21756ea"), "Fantasy" },
                    { new Guid("ba360b30-a254-44c5-8c5e-dcf64b6470a7"), "Horror" },
                    { new Guid("bbb9f3d6-651f-40c6-b78f-e93cc25edd30"), "Travel" },
                    { new Guid("c31e071b-4139-4006-bd1d-82db49724564"), "Literary Fiction" },
                    { new Guid("db2686ad-41b8-4abb-98c9-b7ec8ca310ca"), "Thriller" },
                    { new Guid("dd4b020b-0c12-4f36-a1d8-a5e35b4df7fa"), "Romance" },
                    { new Guid("e2a946d0-88db-486a-8ec4-abaf22fa3594"), "Poetry" }
                });
        }
    }
}
