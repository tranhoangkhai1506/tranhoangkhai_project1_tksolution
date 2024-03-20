using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tranhoangkhai_project1.Migrations
{
    /// <inheritdoc />
    public partial class addTblNhaCungCap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_DM_NCC",
                columns: table => new
                {
                    Ma_NCC = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten_NCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_NCC", x => x.Ma_NCC);
                });

            migrationBuilder.InsertData(
                table: "tbl_DM_NCC",
                columns: new[] { "Ma_NCC", "Ghi_Chu", "Ten_NCC" },
                values: new object[,]
                {
                    { "ncc_01", "Ghi chu 1", "Nha cung cap 1" },
                    { "ncc_02", "Ghi chu 2", "Nha cung cap 2" },
                    { "ncc_03", "Ghi chu 3", "Nha cung cap 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_NCC");
        }
    }
}
