using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Populatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("14134c96-c62b-44e1-9fbe-154e95985b4e"), "Cookbooks" },
                    { new Guid("14db060d-ee2e-460b-b3fc-7cf33878f15b"), "Adventure" },
                    { new Guid("388d270c-4e17-4dfe-8600-d9ace6100e0b"), "Non-Fiction" },
                    { new Guid("4662dd99-7be9-428c-82d6-48de992124b2"), "Horror" },
                    { new Guid("65c5f9a9-74e5-4908-9f91-85d016cabbc7"), "Graphic Novels" },
                    { new Guid("72c95090-df2a-4deb-b004-b60cc6f859b1"), "Fantasy" },
                    { new Guid("74bbc296-22c8-47f2-a7bf-513d7a26fac8"), "Memoir" },
                    { new Guid("770c8ad3-f8c5-461b-b919-be89ba44e6bb"), "Science" },
                    { new Guid("81e77bec-f302-4824-bb1a-85d5db36f244"), "Poetry" },
                    { new Guid("9759196f-6ddd-48ec-8023-bf3d4939ddee"), "Mystery" },
                    { new Guid("a12d55cc-1765-4003-bf4b-e75f001c83b0"), "Literary Fiction" },
                    { new Guid("a4bf4b23-9abf-4192-9f38-4a98d8a69db4"), "Thriller" },
                    { new Guid("a7a36ece-d600-4692-9569-0c4435de445a"), "Fantasy" },
                    { new Guid("a879815c-b86d-486d-913f-398e778ae7d5"), "Science Fiction" },
                    { new Guid("a9b6addc-358a-46af-bef6-fe85d8c1e04e"), "Biography" },
                    { new Guid("d492b0c7-9448-4028-824c-044073426ef4"), "Young Adult" },
                    { new Guid("e36d0506-d7fa-4528-9dae-3fccf5f434bc"), "Travel" },
                    { new Guid("e659876b-929d-4dd6-93e0-1e7551516067"), "Romance" },
                    { new Guid("f2d2beea-2570-434e-b77d-377c4e6faa47"), "Self-Help" },
                    { new Guid("f5da4675-6977-4bdb-a3e0-d51d9c67be9a"), "Historical Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "GenreId", "IsAvailable", "Name" },
                values: new object[,]
                {
                    { new Guid("04fde10e-07d0-4ac2-8fb0-4ceefee1c440"), "J.K. Rowling", new Guid("72c95090-df2a-4deb-b004-b60cc6f859b1"), true, "Harry Potter and the Sorcerer's Stone" },
                    { new Guid("2e34af54-97c9-4faf-a1d6-44ca25121772"), "J.R.R. Tolkien", new Guid("14db060d-ee2e-460b-b3fc-7cf33878f15b"), true, "The Hobbit" },
                    { new Guid("347db0b5-95ea-4db0-aec2-a0ad3217d7d6"), "F. Scott Fitzgerald", new Guid("f5da4675-6977-4bdb-a3e0-d51d9c67be9a"), true, "The Great Gatsby" },
                    { new Guid("35ab1292-61b2-48c2-a536-610db3ec9dae"), "Andrzej Sapkowski", new Guid("a7a36ece-d600-4692-9569-0c4435de445a"), true, "The Last Wish" },
                    { new Guid("4110181e-95dc-439a-b1dc-a1cdb7757583"), "Michelle Obama", new Guid("a9b6addc-358a-46af-bef6-fe85d8c1e04e"), true, "Becoming" },
                    { new Guid("45f73c2b-238a-416f-bb44-1c957474dcaa"), "Stephen King", new Guid("4662dd99-7be9-428c-82d6-48de992124b2"), true, "The Shining" },
                    { new Guid("460d523d-4b95-4ea5-a2a5-1e6e95871500"), "Tara Westover", new Guid("388d270c-4e17-4dfe-8600-d9ace6100e0b"), true, "Educated" },
                    { new Guid("4e5a1332-a404-431e-936f-246180d831b9"), "Eckhart Tolle", new Guid("74bbc296-22c8-47f2-a7bf-513d7a26fac8"), true, "The Power of Now" },
                    { new Guid("6c6cf7be-e936-4f73-9e85-defeb1ae669e"), "Jon Krakauer", new Guid("14134c96-c62b-44e1-9fbe-154e95985b4e"), true, "Into the Wild" },
                    { new Guid("77ec3efd-0945-4587-82c5-720b03b532c0"), "Rupi Kaur", new Guid("81e77bec-f302-4824-bb1a-85d5db36f244"), true, "The Sun and Her Flowers" },
                    { new Guid("7b02fd30-fbd1-4fe9-9c7c-21353d2b8753"), "Dan Brown", new Guid("9759196f-6ddd-48ec-8023-bf3d4939ddee"), true, "The Da Vinci Code" },
                    { new Guid("89485f68-de89-4a15-9052-ddeb1bd49bc0"), "Chrissy Teigen", new Guid("f2d2beea-2570-434e-b77d-377c4e6faa47"), true, "Cravings: Recipes for All the Food You Want to Eat" },
                    { new Guid("8eb6f51c-4e25-4e32-835e-8f50c17de5c7"), "Suzanne Collins", new Guid("d492b0c7-9448-4028-824c-044073426ef4"), true, "The Hunger Games" },
                    { new Guid("97be5873-34bf-413f-9040-3f5170f6935f"), "Jane Austen", new Guid("e659876b-929d-4dd6-93e0-1e7551516067"), true, "Pride and Prejudice" },
                    { new Guid("a850db48-9acd-4fca-a92e-58a27e7299e8"), "Rupi Kaur", new Guid("81e77bec-f302-4824-bb1a-85d5db36f244"), true, "Milk and Honey" },
                    { new Guid("c747ec7c-ab63-4543-8b71-fb641e1ecb6c"), "Harper Lee", new Guid("a12d55cc-1765-4003-bf4b-e75f001c83b0"), true, "To Kill a Mockingbird" },
                    { new Guid("c84cb351-21a3-4761-9c03-36f7faf6d913"), "Frank Herbert", new Guid("a879815c-b86d-486d-913f-398e778ae7d5"), true, "Dune" },
                    { new Guid("cb6b5f70-2335-4ac5-99be-0581ca1a6908"), "Neil Gaiman", new Guid("770c8ad3-f8c5-461b-b919-be89ba44e6bb"), true, "The Sandman" },
                    { new Guid("ce0d6382-f675-419d-8b6e-f9911e6e28b7"), "Gillian Flynn", new Guid("a4bf4b23-9abf-4192-9f38-4a98d8a69db4"), true, "Gone Girl" },
                    { new Guid("ea083009-68aa-46d8-aab8-59b244111d9e"), "Stephen Hawking", new Guid("e36d0506-d7fa-4528-9dae-3fccf5f434bc"), true, "A Brief History of Time" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("04fde10e-07d0-4ac2-8fb0-4ceefee1c440"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e34af54-97c9-4faf-a1d6-44ca25121772"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("347db0b5-95ea-4db0-aec2-a0ad3217d7d6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("35ab1292-61b2-48c2-a536-610db3ec9dae"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4110181e-95dc-439a-b1dc-a1cdb7757583"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("45f73c2b-238a-416f-bb44-1c957474dcaa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("460d523d-4b95-4ea5-a2a5-1e6e95871500"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4e5a1332-a404-431e-936f-246180d831b9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6c6cf7be-e936-4f73-9e85-defeb1ae669e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77ec3efd-0945-4587-82c5-720b03b532c0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7b02fd30-fbd1-4fe9-9c7c-21353d2b8753"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("89485f68-de89-4a15-9052-ddeb1bd49bc0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8eb6f51c-4e25-4e32-835e-8f50c17de5c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("97be5873-34bf-413f-9040-3f5170f6935f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a850db48-9acd-4fca-a92e-58a27e7299e8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c747ec7c-ab63-4543-8b71-fb641e1ecb6c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c84cb351-21a3-4761-9c03-36f7faf6d913"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cb6b5f70-2335-4ac5-99be-0581ca1a6908"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ce0d6382-f675-419d-8b6e-f9911e6e28b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ea083009-68aa-46d8-aab8-59b244111d9e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("65c5f9a9-74e5-4908-9f91-85d016cabbc7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("14134c96-c62b-44e1-9fbe-154e95985b4e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("14db060d-ee2e-460b-b3fc-7cf33878f15b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("388d270c-4e17-4dfe-8600-d9ace6100e0b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4662dd99-7be9-428c-82d6-48de992124b2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("72c95090-df2a-4deb-b004-b60cc6f859b1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("74bbc296-22c8-47f2-a7bf-513d7a26fac8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("770c8ad3-f8c5-461b-b919-be89ba44e6bb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("81e77bec-f302-4824-bb1a-85d5db36f244"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9759196f-6ddd-48ec-8023-bf3d4939ddee"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a12d55cc-1765-4003-bf4b-e75f001c83b0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a4bf4b23-9abf-4192-9f38-4a98d8a69db4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a7a36ece-d600-4692-9569-0c4435de445a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a879815c-b86d-486d-913f-398e778ae7d5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a9b6addc-358a-46af-bef6-fe85d8c1e04e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d492b0c7-9448-4028-824c-044073426ef4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e36d0506-d7fa-4528-9dae-3fccf5f434bc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e659876b-929d-4dd6-93e0-1e7551516067"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f2d2beea-2570-434e-b77d-377c4e6faa47"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f5da4675-6977-4bdb-a3e0-d51d9c67be9a"));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("109fd595-7d14-4c96-8604-b68e5deb74ac"), "Cookbooks" },
                    { new Guid("12799149-ed27-4f34-b5d2-8e8cf108d62d"), "Adventure" },
                    { new Guid("157ba977-3695-4ade-ad17-c54005bf6fb4"), "Fantasy" },
                    { new Guid("28288c1f-12a1-4239-9583-ee4dc5013f5d"), "Poetry" },
                    { new Guid("3557a5ce-39ca-40e1-aa78-cba0aa50ca6a"), "Travel" },
                    { new Guid("362e51c1-ef4c-4d8e-9887-d57910e1e046"), "Science Fiction" },
                    { new Guid("4934509f-46ea-4d6d-9f07-3decbcd51d43"), "Biography" },
                    { new Guid("4b90b5b4-cd4f-4a82-a5c3-13d649523a00"), "Fantasy" },
                    { new Guid("6b1524bc-a763-491c-a844-a507057ca17a"), "Self-Help" },
                    { new Guid("74fbedd6-7d11-4923-80d9-ba2498811396"), "Romance" },
                    { new Guid("772f3779-657e-45e2-bbbe-55b90d89d18f"), "Historical Fiction" },
                    { new Guid("7d2575ac-19e0-4ace-adf3-da6c851a13f3"), "Mystery" },
                    { new Guid("8e19f8c1-919e-4656-9b19-07127110f69d"), "Memoir" },
                    { new Guid("a13af236-a938-48be-a97d-508c4835105b"), "Thriller" },
                    { new Guid("a1ee404c-7e93-4d38-bb4e-42359f4f02f0"), "Science" },
                    { new Guid("b957757d-9dd5-486e-9621-7257474c7dd0"), "Horror" },
                    { new Guid("c52108a7-1e21-44d8-9884-bba300489c78"), "Graphic Novels" },
                    { new Guid("f54c540b-4446-4a65-bc13-ae3b4b751ef7"), "Young Adult" },
                    { new Guid("f7dcd500-c9c1-4693-8bec-2c8cad3c7483"), "Literary Fiction" },
                    { new Guid("fac15666-77d0-4422-ab48-f080dfdab36e"), "Non-Fiction" }
                });
        }
    }
}
