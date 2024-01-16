using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeltExam.Migrations
{
    public partial class migrimiNjerdddxs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersAndProjects_Projects_ProjectId",
                table: "UsersAndProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersAndProjects_Users_UserId",
                table: "UsersAndProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersAndProjects",
                table: "UsersAndProjects");

            migrationBuilder.RenameTable(
                name: "UsersAndProjects",
                newName: "Suporters");

            migrationBuilder.RenameIndex(
                name: "IX_UsersAndProjects_UserId",
                table: "Suporters",
                newName: "IX_Suporters_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersAndProjects_ProjectId",
                table: "Suporters",
                newName: "IX_Suporters_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suporters",
                table: "Suporters",
                column: "SuporterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suporters_Projects_ProjectId",
                table: "Suporters",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suporters_Users_UserId",
                table: "Suporters",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suporters_Projects_ProjectId",
                table: "Suporters");

            migrationBuilder.DropForeignKey(
                name: "FK_Suporters_Users_UserId",
                table: "Suporters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suporters",
                table: "Suporters");

            migrationBuilder.RenameTable(
                name: "Suporters",
                newName: "UsersAndProjects");

            migrationBuilder.RenameIndex(
                name: "IX_Suporters_UserId",
                table: "UsersAndProjects",
                newName: "IX_UsersAndProjects_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Suporters_ProjectId",
                table: "UsersAndProjects",
                newName: "IX_UsersAndProjects_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersAndProjects",
                table: "UsersAndProjects",
                column: "SuporterId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAndProjects_Projects_ProjectId",
                table: "UsersAndProjects",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAndProjects_Users_UserId",
                table: "UsersAndProjects",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
