using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tranhoangkhai_project1.Migrations
{
    /// <inheritdoc />
    public partial class addTblPhieuNhapKho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_DM_Nhap_Kho",
                columns: table => new
                {
                    So_Phieu_Nhap_Kho = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Kho_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NCC_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngay_Nhap_Kho = table.Column<DateTime>(type: "Date", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Nhap_Kho", x => x.So_Phieu_Nhap_Kho);
                });

            migrationBuilder.InsertData(
                table: "tbl_DM_Nhap_Kho",
                columns: new[] { "So_Phieu_Nhap_Kho", "Ghi_Chu", "Kho_ID", "NCC_ID", "Ngay_Nhap_Kho" },
                values: new object[,]
                {
                    { "pn_01", "Ghi chu 1", "Kho_01", "ncc_01", new DateTime(2024, 3, 22, 8, 58, 34, 459, DateTimeKind.Local).AddTicks(7722) },
                    { "pn_02", "Ghi chu 2", "Kho_02", "ncc_02", new DateTime(2024, 3, 22, 8, 58, 34, 459, DateTimeKind.Local).AddTicks(7735) },
                    { "pn_03", "Ghi chu 3", "Kho_03", "ncc_03", new DateTime(2024, 3, 22, 8, 58, 34, 459, DateTimeKind.Local).AddTicks(7737) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_Nhap_Kho");
        }
    }
}
