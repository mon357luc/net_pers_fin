using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace net_pers_fin.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    first = table.Column<string>(type: "TEXT", nullable: false),
                    last = table.Column<string>(type: "TEXT", nullable: false),
                    active = table.Column<int>(type: "INTEGER", nullable: false),
                    verified = table.Column<int>(type: "INTEGER", nullable: false),
                    createdon = table.Column<DateTime>(type: "TEXT", nullable: false),
                    lastlogin = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
