using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tranhoangkhai_project1.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_DM_Don_Vi_Tinh",
                columns: table => new
                {
                    Ten_Don_Vi_Tinh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Don_Vi_Tinh", x => x.Ten_Don_Vi_Tinh);
                });

            migrationBuilder.InsertData(
                table: "tbl_DM_Don_Vi_Tinh",
                columns: new[] { "Ten_Don_Vi_Tinh", "Ghi_Chu" },
                values: new object[,]
                {
                    { "dvt_01", "Ghi chu 1" },
                    { "dvt_02", "Ghi chu 2" },
                    { "dvt_03", "Ghi chu 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_Don_Vi_Tinh");
        }
    }
}
