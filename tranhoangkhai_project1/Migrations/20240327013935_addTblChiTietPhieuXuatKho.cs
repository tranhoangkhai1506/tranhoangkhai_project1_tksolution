using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tranhoangkhai_project1.Migrations
{
    /// <inheritdoc />
    public partial class addTblChiTietPhieuXuatKho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HieuChinhPhieuXuatKhoModel",
                table: "HieuChinhPhieuXuatKhoModel");

            migrationBuilder.RenameTable(
                name: "HieuChinhPhieuXuatKhoModel",
                newName: "tbl_XNK_Xuat_Kho");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_XNK_Xuat_Kho",
                table: "tbl_XNK_Xuat_Kho",
                column: "So_Phieu_Xuat_Kho");

            migrationBuilder.CreateTable(
                name: "tbl_DM_Xuat_Kho_Raw_Data",
                columns: table => new
                {
                    Xuat_Kho_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    San_Pham_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SL_Xuat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Don_Gia_Xuat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DM_Xuat_Kho_Raw_Data", x => new { x.Xuat_Kho_ID, x.San_Pham_ID });
                });

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_01",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 39, 35, 212, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_02",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 39, 35, 212, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_03",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 39, 35, 212, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Xuat_Kho",
                keyColumn: "So_Phieu_Xuat_Kho",
                keyValue: "px_01",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 39, 35, 212, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Xuat_Kho",
                keyColumn: "So_Phieu_Xuat_Kho",
                keyValue: "px_02",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 39, 35, 212, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Xuat_Kho",
                keyColumn: "So_Phieu_Xuat_Kho",
                keyValue: "px_03",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 39, 35, 212, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.InsertData(
                table: "tbl_DM_Xuat_Kho_Raw_Data",
                columns: new[] { "San_Pham_ID", "Xuat_Kho_ID", "Don_Gia_Xuat", "SL_Xuat" },
                values: new object[,]
                {
                    { "sp_01", "px_01", 2000000m, 100m },
                    { "sp_02", "px_02", 4000000m, 200m },
                    { "sp_03", "px_03", 5000000m, 300m }
                });

            migrationBuilder.UpdateData(
                table: "tbl_XNK_Xuat_Kho",
                keyColumn: "So_Phieu_Xuat_Kho",
                keyValue: "px_01",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 39, 35, 212, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "tbl_XNK_Xuat_Kho",
                keyColumn: "So_Phieu_Xuat_Kho",
                keyValue: "px_02",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 39, 35, 212, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "tbl_XNK_Xuat_Kho",
                keyColumn: "So_Phieu_Xuat_Kho",
                keyValue: "px_03",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 39, 35, 212, DateTimeKind.Local).AddTicks(7095));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_DM_Xuat_Kho_Raw_Data");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_XNK_Xuat_Kho",
                table: "tbl_XNK_Xuat_Kho");

            migrationBuilder.RenameTable(
                name: "tbl_XNK_Xuat_Kho",
                newName: "HieuChinhPhieuXuatKhoModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HieuChinhPhieuXuatKhoModel",
                table: "HieuChinhPhieuXuatKhoModel",
                column: "So_Phieu_Xuat_Kho");

            migrationBuilder.UpdateData(
                table: "HieuChinhPhieuXuatKhoModel",
                keyColumn: "So_Phieu_Xuat_Kho",
                keyValue: "px_01",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 38, 19, 450, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "HieuChinhPhieuXuatKhoModel",
                keyColumn: "So_Phieu_Xuat_Kho",
                keyValue: "px_02",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 38, 19, 450, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "HieuChinhPhieuXuatKhoModel",
                keyColumn: "So_Phieu_Xuat_Kho",
                keyValue: "px_03",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 38, 19, 450, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_01",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 38, 19, 449, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_02",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 38, 19, 449, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Nhap_Kho",
                keyColumn: "So_Phieu_Nhap_Kho",
                keyValue: "pn_03",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 38, 19, 449, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Xuat_Kho",
                keyColumn: "So_Phieu_Xuat_Kho",
                keyValue: "px_01",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 38, 19, 449, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Xuat_Kho",
                keyColumn: "So_Phieu_Xuat_Kho",
                keyValue: "px_02",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 38, 19, 449, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "tbl_DM_Xuat_Kho",
                keyColumn: "So_Phieu_Xuat_Kho",
                keyValue: "px_03",
                column: "Ngay_Nhap_Kho",
                value: new DateTime(2024, 3, 27, 8, 38, 19, 449, DateTimeKind.Local).AddTicks(8654));
        }
    }
}
