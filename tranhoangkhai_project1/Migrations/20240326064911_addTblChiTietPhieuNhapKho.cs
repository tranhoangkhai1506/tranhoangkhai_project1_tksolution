using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tranhoangkhai_project1.Migrations
{
    /// <inheritdoc />
    public partial class addTblChiTietPhieuNhapKho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_DM_Nhap_Kho_Raw_Data",
                columns: table => new
                {
                    Nhap_Kho_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    San_Pham_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SL_Nhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Don_Gia_Nhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Nhap_Kho_Raw_Data", x => new { x.Nhap_Kho_ID, x.San_Pham_ID });
                });

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_01",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 26, 13, 49, 11, 128, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_02",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 26, 13, 49, 11, 128, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_03",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 26, 13, 49, 11, 128, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.InsertData(
                table: "tbl_DM_Nhap_Kho_Raw_Data",
                columns: new[] { "Nhap_Kho_ID", "San_Pham_ID", "Don_Gia_Nhap", "SL_Nhap" },
                values: new object[,]
                {
                    { "pn_01", "sp_01", 2000000m, 100m },
                    { "pn_02", "sp_01", 4000000m, 200m },
                    { "pn_03", "sp_01", 5000000m, 300m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_Nhap_Kho_Raw_Data");

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_01",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 22, 17, 29, 40, 395, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_02",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 22, 17, 29, 40, 395, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_03",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 22, 17, 29, 40, 395, DateTimeKind.Local).AddTicks(1868));
        }
    }
}
