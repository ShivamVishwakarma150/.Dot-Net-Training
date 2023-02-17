using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCorePractice_WebApp_MVC.Migrations
{
    public partial class BatchFileUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Batches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainerId",
                table: "Batches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Batches_CourseId",
                table: "Batches",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Batches_TrainerId",
                table: "Batches",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Batches_Courses_CourseId",
                table: "Batches",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Batches_Trainers_TrainerId",
                table: "Batches",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batches_Courses_CourseId",
                table: "Batches");

            migrationBuilder.DropForeignKey(
                name: "FK_Batches_Trainers_TrainerId",
                table: "Batches");

            migrationBuilder.DropIndex(
                name: "IX_Batches_CourseId",
                table: "Batches");

            migrationBuilder.DropIndex(
                name: "IX_Batches_TrainerId",
                table: "Batches");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Batches");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Batches");
        }
    }
}
