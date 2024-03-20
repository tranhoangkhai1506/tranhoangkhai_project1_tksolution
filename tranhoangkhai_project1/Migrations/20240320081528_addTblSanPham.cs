using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tranhoangkhai_project1.Migrations
{
    /// <inheritdoc />
    public partial class addTblSanPham : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_DM_San_Pham",
                columns: table => new
                {
                    Ma_San_Pham = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten_San_Pham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loai_San_Pham_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Don_Vi_Tinh_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_San_Pham", x => x.Ma_San_Pham);
                });

            migrationBuilder.InsertData(
                table: "tbl_DM_San_Pham",
                columns: new[] { "Ma_San_Pham", "Don_Vi_Tinh_ID", "Ghi_Chu", "Loai_San_Pham_ID", "Ten_San_Pham" },
                values: new object[,]
                {
                    { "sp_01", "dvt_01", "Ghi chu 1", "lsp_01", "San Pham 1" },
                    { "sp_02", "dvt_02", "Ghi chu 2", "lsp_02", "San Pham 1 2" },
                    { "sp_03", "dvt_02", "Ghi chu 3", "lsp_03", "San Pham 1 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_San_Pham");
        }
    }
}
