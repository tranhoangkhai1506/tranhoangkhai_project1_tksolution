using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tranhoangkhai_project1.Migrations
{
    /// <inheritdoc />
    public partial class addTblPhieuXuatKho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_DM_Xuat_Kho",
                columns: table => new
                {
                    So_Phieu_Xuat_Kho = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Kho_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngay_Nhap_Kho = table.Column<DateTime>(type: "Date", nullable: false),
                    Ghi_Chu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Xuat_Kho", x => x.So_Phieu_Xuat_Kho);
                });

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_01",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 36, 56, 4, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_02",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 36, 56, 4, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_03",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 36, 56, 4, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.InsertData(
                table: "tbl_DM_Xuat_Kho",
                columns: new[] { "So_Phieu_Xuat_Kho", "Ghi_Chu", "Kho_ID", "Ngay_Nhap_Kho" },
                values: new object[,]
                {
                    { "px_01", "Ghi chu 1", "Kho_01", new DateTime(2024, 3, 27, 8, 36, 56, 5, DateTimeKind.Local).AddTicks(577) },
                    { "px_02", "Ghi chu 2", "Kho_02", new DateTime(2024, 3, 27, 8, 36, 56, 5, DateTimeKind.Local).AddTicks(580) },
                    { "px_03", "Ghi chu 3", "Kho_03", new DateTime(2024, 3, 27, 8, 36, 56, 5, DateTimeKind.Local).AddTicks(582) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_Xuat_Kho");

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
        }
    }
}
