using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patropns_LibraryBranches_HomeLibraryBranchId",
                table: "Patropns");

            migrationBuilder.DropForeignKey(
                name: "FK_Patropns_LibraryCards_LibraryCardId",
                table: "Patropns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patropns",
                table: "Patropns");

            migrationBuilder.RenameTable(
                name: "Patropns",
                newName: "Patrons");

            migrationBuilder.RenameIndex(
                name: "IX_Patropns_LibraryCardId",
                table: "Patrons",
                newName: "IX_Patrons_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Patropns_HomeLibraryBranchId",
                table: "Patrons",
                newName: "IX_Patrons_HomeLibraryBranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patrons",
                table: "Patrons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons",
                column: "HomeLibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patrons",
                table: "Patrons");

            migrationBuilder.RenameTable(
                name: "Patrons",
                newName: "Patropns");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_LibraryCardId",
                table: "Patropns",
                newName: "IX_Patropns_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_HomeLibraryBranchId",
                table: "Patropns",
                newName: "IX_Patropns_HomeLibraryBranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patropns",
                table: "Patropns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patropns_LibraryBranches_HomeLibraryBranchId",
                table: "Patropns",
                column: "HomeLibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patropns_LibraryCards_LibraryCardId",
                table: "Patropns",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
