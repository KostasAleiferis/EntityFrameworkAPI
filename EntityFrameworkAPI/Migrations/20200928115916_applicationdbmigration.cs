using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkAPI.Migrations
{
    public partial class applicationdbmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PortalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 32, nullable: false),
                    LastName = table.Column<string>(maxLength: 32, nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: false),
                    Country = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    TelCountryCode = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    MobileCountryCode = table.Column<string>(nullable: false),
                    Mobile = table.Column<string>(nullable: false),
                    IdentificationNum = table.Column<string>(maxLength: 50, nullable: false),
                    IdentificationNumType = table.Column<string>(nullable: false),
                    IdentificationNumExpiration = table.Column<DateTime>(nullable: false),
                    OrganizationId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalUsers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortalUsers");
        }
    }
}
