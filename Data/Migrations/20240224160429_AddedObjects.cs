using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddedObjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7a812d08-6189-4c81-a1a2-7013b80b3cbd", "556dd111-4969-454a-868f-4dea938af0fe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "860dfa0d-5e55-489a-b810-2ebe7bf11d7f", "c437c0fd-614d-42d2-9ba7-05cf7c03db5b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a812d08-6189-4c81-a1a2-7013b80b3cbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "860dfa0d-5e55-489a-b810-2ebe7bf11d7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "556dd111-4969-454a-868f-4dea938af0fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c437c0fd-614d-42d2-9ba7-05cf7c03db5b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67ad0d8d-145a-447b-8805-28cdbb97a734", "67ad0d8d-145a-447b-8805-28cdbb97a734", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "97234998-9ca5-4421-820f-d538bb4f123b", "97234998-9ca5-4421-820f-d538bb4f123b", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5cfc33fc-7186-4ae1-aa24-3956c812bc3e", 0, "e1819e7c-c52d-45ba-bf83-d991fc64ed46", "user@gmail.com", true, false, null, "USER@GMAIL.COM", "USER", "AQAAAAEAACcQAAAAEJ4TZTMXIOSCZV6HXTcCbBWu5uOwZd40sWHP/h8wkM+Rc3N9xFSmMg65gfI4OvJIRA==", null, false, "05c03e34-03d3-4fd7-b2c7-e64dcece89c5", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bd51b498-042b-4022-945a-ff6feb81174a", 0, "0b496584-c925-47d6-9a77-a4256d76cba9", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEH99qqnmI1d97ydNKLc4ySEK9L+I56vHURNiVb0yLCHXKuC/gYYSzfiTPnhFJb80Bw==", null, false, "0c920965-5a94-4c27-8fa4-f9dd22e35cec", false, "admin" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "Surname" },
                values: new object[] { 1, "John", "Doe" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "Surname" },
                values: new object[] { 2, "Jane", "Smith" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "Surname" },
                values: new object[] { 3, "Michael", "Johnson" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "Surname" },
                values: new object[] { 4, "Emily", "Brown" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "Surname" },
                values: new object[] { 5, "David", "Williams" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "Surname" },
                values: new object[] { 6, "Sarah", "Jones" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "Surname" },
                values: new object[] { 7, "Daniel", "Garcia" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "Surname" },
                values: new object[] { 8, "Jessica", "Martinez" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "Surname" },
                values: new object[] { 9, "James", "Lee" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "Surname" },
                values: new object[] { 10, "Sophia", "Lopez" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "id", "AuthorId", "City", "Country", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { 1, 7, "Anytown", 1, "Apt 101", "12345", "123 Main Street" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "id", "AuthorId", "City", "Country", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { 2, 6, "Othertown", 2, "Unit 202", "67890", "456 Elm Street" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "id", "AuthorId", "City", "Country", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { 3, 5, "Somewhere", 3, "Suite 303", "ABCDE", "789 Oak Avenue" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "id", "AuthorId", "City", "Country", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { 4, 4, "Anothercity", 4, "Unit 404", "WXYZ", "321 Pine Lane" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "id", "AuthorId", "City", "Country", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { 5, 3, "Yetanothercity", 5, "Apt 505", "54321", "555 Cedar Street" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "id", "AuthorId", "City", "Country", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { 6, 2, "Anotherplace", 6, "Suite 606", "FGHIJ", "777 Maple Avenue" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "id", "AuthorId", "City", "Country", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { 7, 1, "Someplace", 7, "Unit 707", "LMNOP", "999 Birch Road" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "id", "AuthorId", "City", "Country", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { 8, 1, "Yetanotherplace", 8, "Apartment 808", "QRSTU", "111 Oak Street" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "97234998-9ca5-4421-820f-d538bb4f123b", "5cfc33fc-7186-4ae1-aa24-3956c812bc3e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "67ad0d8d-145a-447b-8805-28cdbb97a734", "bd51b498-042b-4022-945a-ff6feb81174a" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AuthorEmail", "AuthorId", "Camera", "taken_date", "Description", "Format", "Resolution" },
                values: new object[] { 1, "john.doe@example.com", 1, "Canon EOS 5D Mark IV", new DateTime(2023, 5, 15, 13, 30, 0, 0, DateTimeKind.Unspecified), "Beautiful landscape", "c.png", "6000x4000" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AuthorEmail", "AuthorId", "Camera", "taken_date", "Description", "Format", "Resolution" },
                values: new object[] { 2, "jane.smith@example.com", 2, "Nikon D850", new DateTime(2023, 6, 20, 10, 15, 0, 0, DateTimeKind.Unspecified), "Sunset on the beach", "b.png", "8256x5504" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AuthorEmail", "AuthorId", "Camera", "taken_date", "Description", "Format", "Resolution" },
                values: new object[] { 3, "michael.johnson@example.com", 3, "Sony Alpha a7 III", new DateTime(2023, 7, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), "Urban cityscape", "a.png", "6000x3376" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AuthorEmail", "AuthorId", "Camera", "taken_date", "Description", "Format", "Resolution" },
                values: new object[] { 6, "emily.brown@example.com", 4, "Fujifilm X-T4", new DateTime(2023, 8, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), "Mountain peak", "w.jpg", "6240x4160" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AuthorEmail", "AuthorId", "Camera", "taken_date", "Description", "Format", "Resolution" },
                values: new object[] { 7, "david.williams@example.com", 5, "Leica Q2", new DateTime(2023, 9, 12, 12, 30, 0, 0, DateTimeKind.Unspecified), "Historic landmark", "dsd.jpg", "8368x5584" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AuthorEmail", "AuthorId", "Camera", "taken_date", "Description", "Format", "Resolution" },
                values: new object[] { 8, "sarah.jones@example.com", 6, "Panasonic Lumix S5", new DateTime(2023, 10, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), "Colorful street art", "fa.jpg", "6000x4000" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AuthorEmail", "AuthorId", "Camera", "taken_date", "Description", "Format", "Resolution" },
                values: new object[] { 9, "daniel.garcia@example.com", 7, "Olympus OM-D E-M1 Mark III", new DateTime(2023, 11, 8, 16, 45, 0, 0, DateTimeKind.Unspecified), "Spectacular waterfall", "bfd.jpg", "5184x3888" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AuthorEmail", "AuthorId", "Camera", "taken_date", "Description", "Format", "Resolution" },
                values: new object[] { 10, "jessica.martinez@example.com", 8, "Pentax K-1 Mark II", new DateTime(2023, 12, 20, 9, 15, 0, 0, DateTimeKind.Unspecified), "Winter wonderland", "fas.jpg", "7360x4912" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "97234998-9ca5-4421-820f-d538bb4f123b", "5cfc33fc-7186-4ae1-aa24-3956c812bc3e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "67ad0d8d-145a-447b-8805-28cdbb97a734", "bd51b498-042b-4022-945a-ff6feb81174a" });

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67ad0d8d-145a-447b-8805-28cdbb97a734");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97234998-9ca5-4421-820f-d538bb4f123b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cfc33fc-7186-4ae1-aa24-3956c812bc3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd51b498-042b-4022-945a-ff6feb81174a");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a812d08-6189-4c81-a1a2-7013b80b3cbd", "7a812d08-6189-4c81-a1a2-7013b80b3cbd", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "860dfa0d-5e55-489a-b810-2ebe7bf11d7f", "860dfa0d-5e55-489a-b810-2ebe7bf11d7f", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "556dd111-4969-454a-868f-4dea938af0fe", 0, "61fd21c7-4321-4aa4-ad4c-dbbf2f6b145d", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEOzJn2XIpElUmiN0xnAJlzfDcq78Y85/xw9XSsPNFna7b5cQvU/3TvDQudFTebULSg==", null, false, "49e36c6b-8d08-42bd-ae00-dbf08de975ca", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c437c0fd-614d-42d2-9ba7-05cf7c03db5b", 0, "cf70cce7-89f0-4e62-b747-ce52cd62e3b8", "user@gmail.com", true, false, null, "USER@GMAIL.COM", "USER", "AQAAAAEAACcQAAAAENRS9RpNQNPnWT28QeBiSSJUBOVEROHBhf+uBrEDpB+5ZwxVlXsScLvgPQPwwIn4Sg==", null, false, "b448c1cd-0f4d-4569-ad1b-ad571a844f8a", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7a812d08-6189-4c81-a1a2-7013b80b3cbd", "556dd111-4969-454a-868f-4dea938af0fe" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "860dfa0d-5e55-489a-b810-2ebe7bf11d7f", "c437c0fd-614d-42d2-9ba7-05cf7c03db5b" });
        }
    }
}
