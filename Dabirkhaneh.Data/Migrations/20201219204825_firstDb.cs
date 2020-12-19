using Microsoft.EntityFrameworkCore.Migrations;

namespace Dabirkhaneh.Data.Migrations
{
    public partial class firstDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_TArchives_TArchives_TArchiveId",
            //    table: "TArchives");

            //migrationBuilder.DropIndex(
            //    name: "IX_TArchives_TArchiveId",
            //    table: "TArchives");

            //migrationBuilder.DropColumn(
            //    name: "TArchiveId",
            //    table: "TArchives");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //    migrationBuilder.AddColumn<int>(
            //        name: "TArchiveId",
            //        table: "TArchives",
            //        type: "int",
            //        nullable: false,
            //        defaultValue: 0);

            //    migrationBuilder.CreateIndex(
            //        name: "IX_TArchives_TArchiveId",
            //        table: "TArchives",
            //        column: "TArchiveId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_TArchives_TArchives_TArchiveId",
            //    table: "TArchives",
            //    column: "TArchiveId",
            //    principalTable: "TArchives",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
