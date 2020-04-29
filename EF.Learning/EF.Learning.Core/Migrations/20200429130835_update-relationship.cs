using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.Learning.Core.Migrations
{
    public partial class updaterelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationTag_Applications_ApplicationId1",
                table: "ApplicationTag");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationTag_ApplicationId1",
                table: "ApplicationTag");

            migrationBuilder.DropColumn(
                name: "ApplicationId1",
                table: "ApplicationTag");

            migrationBuilder.DropColumn(
                name: "Tag",
                table: "ApplicationTag");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicationId1",
                table: "ApplicationTag",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tag",
                table: "ApplicationTag",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationTag_ApplicationId1",
                table: "ApplicationTag",
                column: "ApplicationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationTag_Applications_ApplicationId1",
                table: "ApplicationTag",
                column: "ApplicationId1",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
