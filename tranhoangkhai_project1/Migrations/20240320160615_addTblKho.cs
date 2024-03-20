using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tranhoangkhai_project1.Migrations
{
    /// <inheritdoc />
    public partial class addTblKho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_DM_Kho",
                columns: table => new
                {
                    Ten_Kho = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Kho", x => x.Ten_Kho);
                });

            migrationBuilder.InsertData(
                table: "tbl_DM_Kho",
                columns: new[] { "Ten_Kho", "Ghi_Chu" },
                values: new object[,]
                {
                    { "Kho_01", "Ghi chu 1" },
                    { "Kho_02", "Ghi chu 2" },
                    { "Kho_03", "Ghi chu 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_Kho");
        }
    }
}
