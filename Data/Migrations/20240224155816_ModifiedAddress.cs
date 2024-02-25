using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class ModifiedAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Authors_AuthorEntityId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_AuthorEntityId",
                table: "Address");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4538119a-a5ef-4d7b-9738-1c80354f677d", "70e1dc2a-ee22-4d14-82f3-685365e5e028" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d80c7da-65f7-4931-ac11-64b83e24ce46", "dd634750-fab6-4485-ae77-6fef4a2f3184" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d80c7da-65f7-4931-ac11-64b83e24ce46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4538119a-a5ef-4d7b-9738-1c80354f677d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70e1dc2a-ee22-4d14-82f3-685365e5e028");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd634750-fab6-4485-ae77-6fef4a2f3184");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "AuthorEntityId",
                table: "Address");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Address",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Address_AuthorId",
                table: "Address",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Authors_AuthorId",
                table: "Address",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Authors_AuthorId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_AuthorId",
                table: "Address");

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

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Address");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Authors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AuthorEntityId",
                table: "Address",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d80c7da-65f7-4931-ac11-64b83e24ce46", "2d80c7da-65f7-4931-ac11-64b83e24ce46", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4538119a-a5ef-4d7b-9738-1c80354f677d", "4538119a-a5ef-4d7b-9738-1c80354f677d", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "70e1dc2a-ee22-4d14-82f3-685365e5e028", 0, "c1b7a0a1-5ad8-4f2f-840c-f3a233ce2dbb", "user@gmail.com", true, false, null, "USER@GMAIL.COM", "USER", "AQAAAAEAACcQAAAAEBi2qkSXRDPAcCbv3YUeyuiIGV2XhIBRDBHLgJcRg22odzklty+xUrCFCymOsz2ddw==", null, false, "0760d5b8-ba6a-43a0-9f69-d9cb0b82fbf5", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dd634750-fab6-4485-ae77-6fef4a2f3184", 0, "4e8580c4-5c46-4642-a38c-6327e2e54150", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAENFkRvhWObyPX5yN32tBzqgTVs+3ZmdXy4ynSIASXdVV7aMj7T/TjnwZZj6wULAfPw==", null, false, "33495b00-328a-44d9-a81e-8a3629d34e2d", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4538119a-a5ef-4d7b-9738-1c80354f677d", "70e1dc2a-ee22-4d14-82f3-685365e5e028" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2d80c7da-65f7-4931-ac11-64b83e24ce46", "dd634750-fab6-4485-ae77-6fef4a2f3184" });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AuthorEntityId",
                table: "Address",
                column: "AuthorEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Authors_AuthorEntityId",
                table: "Address",
                column: "AuthorEntityId",
                principalTable: "Authors",
                principalColumn: "Id");
        }
    }
}
