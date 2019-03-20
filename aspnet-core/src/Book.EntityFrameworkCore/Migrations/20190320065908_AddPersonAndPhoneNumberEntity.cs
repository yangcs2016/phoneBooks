using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Book.Migrations
{
    public partial class AddPersonAndPhoneNumberEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "PB");

            migrationBuilder.CreateTable(
                name: "Persoon",
                schema: "PB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 80, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persoon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                schema: "PB",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(maxLength: 11, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: true),
                    PersionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Persoon_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "PB",
                        principalTable: "Persoon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PersonId",
                schema: "PB",
                table: "PhoneNumber",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneNumber",
                schema: "PB");

            migrationBuilder.DropTable(
                name: "Persoon",
                schema: "PB");
        }
    }
}
