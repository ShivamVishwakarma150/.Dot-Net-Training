using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UPIWallet_CodeFirstEFCore.Migrations
{
    public partial class IntialCreationOfDbAndtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UPIModels",
                columns: table => new
                {
                    UPI = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Mobile = table.Column<long>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    JoinedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPIModels", x => x.UPI);
                });

            migrationBuilder.CreateTable(
                name: "TransactionModels",
                columns: table => new
                {
                    TransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    UPI1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionModels", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_TransactionModels_UPIModels_UPI1",
                        column: x => x.UPI1,
                        principalTable: "UPIModels",
                        principalColumn: "UPI",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionModels_UPI1",
                table: "TransactionModels",
                column: "UPI1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionModels");

            migrationBuilder.DropTable(
                name: "UPIModels");
        }
    }
}
