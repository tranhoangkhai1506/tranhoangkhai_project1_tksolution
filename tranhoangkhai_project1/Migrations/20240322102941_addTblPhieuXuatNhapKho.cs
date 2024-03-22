using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tranhoangkhai_project1.Migrations
{
    /// <inheritdoc />
    public partial class addTblPhieuXuatNhapKho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_XNK_Nhap_Kho",
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
                    table.PrimaryKey("PK_tbl_XNK_Nhap_Kho", x => x.So_Phieu_Nhap_Kho);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_XNK_Nhap_Kho");

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_01",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 22, 8, 58, 34, 459, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_02",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 22, 8, 58, 34, 459, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_03",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 22, 8, 58, 34, 459, DateTimeKind.Local).AddTicks(7737));
        }
    }
}
