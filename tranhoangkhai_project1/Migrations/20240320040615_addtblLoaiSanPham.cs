using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tranhoangkhai_project1.Migrations
{
    /// <inheritdoc />
    public partial class addtblLoaiSanPham : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_DM_Loai_San_Pham",
                columns: table => new
                {
                    Ma_LSP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten_LSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Loai_San_Pham", x => x.Ma_LSP);
                });

            migrationBuilder.InsertData(
                table: "tbl_DM_Loai_San_Pham",
                columns: new[] { "Ma_LSP", "Ghi_Chu", "Ten_LSP" },
                values: new object[,]
                {
                    { "lsp_01", "Ghi chu 1", "Loai 1" },
                    { "lsp_02", "Ghi chu 2", "Loai 2" },
                    { "lsp_03", "Ghi chu 3", "Loai 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_Loai_San_Pham");
        }
    }
}
