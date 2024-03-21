using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tranhoangkhai_project1.Migrations
{
    /// <inheritdoc />
    public partial class addTbltbl_DM_Kho_User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_DM_Kho_User",
                columns: table => new
                {
                    Ma_Dang_Nhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Kho_ID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Kho_User", x => x.Ma_Dang_Nhap);
                });

            migrationBuilder.InsertData(
                table: "tbl_DM_Kho_User",
                columns: new[] { "Ma_Dang_Nhap", "Kho_ID" },
                values: new object[,]
                {
                    { "qlkho1", "Kho_01" },
                    { "qlkho2", "Kho_02" },
                    { "qlkho3", "Kho_03" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_Kho_User");
        }
    }
}
