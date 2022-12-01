using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class _12012022_1243_UPdateDB_HinhThucThanhToan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_Anh_AnhsId",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_ChatLieu",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_DeGiay",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_KieuDang",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_MauSac",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_NSX",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_SanPham",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_Size",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietKhuyenMai_KhuyenMai",
                table: "ChiTietKhuyenMai");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KhachHang",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanVien",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonChiTiet_ChiTietGiay",
                table: "HoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonChiTiet_ChiTietKhuyenMai",
                table: "HoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonChiTiet_HoaDon",
                table: "HoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_ChucVu",
                table: "NhanVien");

            migrationBuilder.DropTable(
                name: "GioHangChiTiet");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonChiTiet_idKhuyenMai",
                table: "HoaDonChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietGiay_AnhsId",
                table: "ChiTietGiay");

            migrationBuilder.DropColumn(
                name: "IdCongThuc",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "Anh",
                table: "ChiTietGiay");

            migrationBuilder.DropColumn(
                name: "AnhsId",
                table: "ChiTietGiay");

            migrationBuilder.RenameColumn(
                name: "idSanOham",
                table: "HoaDon",
                newName: "idSanPham");

            migrationBuilder.RenameColumn(
                name: "idHoaDonChiTiet",
                table: "ChiTietKhuyenMai",
                newName: "idChiTietGiay");

            migrationBuilder.RenameColumn(
                name: "IdAnh",
                table: "ChiTietGiay",
                newName: "idAnh");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                table: "Anh",
                newName: "trangThai");

            migrationBuilder.RenameColumn(
                name: "TenAnh",
                table: "Anh",
                newName: "tenAnh");

            migrationBuilder.RenameColumn(
                name: "MaAnh",
                table: "Anh",
                newName: "maAnh");

            migrationBuilder.RenameColumn(
                name: "DuongDan",
                table: "Anh",
                newName: "duongDan");

            migrationBuilder.AlterDatabase(
                oldCollation: "SQL_Latin1_General_CP1_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "Size",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "NSX",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "NhanVien",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "MauSac",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "KieuDang",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "KhachHang",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idHoaDon",
                table: "HoaDonChiTiet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ThanhTien",
                table: "HoaDonChiTiet",
                type: "decimal(18,0)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DonGia",
                table: "HoaDonChiTiet",
                type: "decimal(18,0)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "HoaDon",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GiamGia",
                table: "HoaDon",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "HoaDon",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayNhanHang",
                table: "HoaDon",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTraHang",
                table: "HoaDon",
                type: "date",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "ChucVu",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "ChiTietGiay",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "ChatLieu",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "HinhThucThanhToan",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<int>(type: "int", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "date", maxLength: 50, nullable: true),
                    NgaySua = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: true),
                    LoaiHinhThanhToan = table.Column<int>(type: "int", nullable: true),
                    TongTienThanhToan = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhThucThanhToan", x => x.id);
                    table.ForeignKey(
                        name: "FK_HinhThucThanhToan_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_idSanPham",
                table: "HoaDon",
                column: "idSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKhuyenMai_idChiTietGiay",
                table: "ChiTietKhuyenMai",
                column: "idChiTietGiay");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_idAnh",
                table: "ChiTietGiay",
                column: "idAnh");

            migrationBuilder.CreateIndex(
                name: "IX_HinhThucThanhToan_IdHoaDon",
                table: "HinhThucThanhToan",
                column: "IdHoaDon");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_Anh_idAnh",
                table: "ChiTietGiay",
                column: "idAnh",
                principalTable: "Anh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_ChatLieu_idChatLieu",
                table: "ChiTietGiay",
                column: "idChatLieu",
                principalTable: "ChatLieu",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_DeGiay_idDeGiay",
                table: "ChiTietGiay",
                column: "idDeGiay",
                principalTable: "DeGiay",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_KieuDang_idKieuDang",
                table: "ChiTietGiay",
                column: "idKieuDang",
                principalTable: "KieuDang",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_MauSac_idMauSac",
                table: "ChiTietGiay",
                column: "idMauSac",
                principalTable: "MauSac",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_NSX_idNSX",
                table: "ChiTietGiay",
                column: "idNSX",
                principalTable: "NSX",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_SanPham_idSanPham",
                table: "ChiTietGiay",
                column: "idSanPham",
                principalTable: "SanPham",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_Size_IdSize",
                table: "ChiTietGiay",
                column: "IdSize",
                principalTable: "Size",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietKhuyenMai_ChiTietGiay_idChiTietGiay",
                table: "ChiTietKhuyenMai",
                column: "idChiTietGiay",
                principalTable: "ChiTietGiay",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietKhuyenMai_KhuyenMai_idKhuyenMai",
                table: "ChiTietKhuyenMai",
                column: "idKhuyenMai",
                principalTable: "KhuyenMai",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KhachHang_idKhachHang",
                table: "HoaDon",
                column: "idKhachHang",
                principalTable: "KhachHang",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanVien_idNhanVien",
                table: "HoaDon",
                column: "idNhanVien",
                principalTable: "NhanVien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_SanPham_idSanPham",
                table: "HoaDon",
                column: "idSanPham",
                principalTable: "SanPham",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonChiTiet_ChiTietGiay_idChiTietGiay",
                table: "HoaDonChiTiet",
                column: "idChiTietGiay",
                principalTable: "ChiTietGiay",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonChiTiet_HoaDon_idHoaDon",
                table: "HoaDonChiTiet",
                column: "idHoaDon",
                principalTable: "HoaDon",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_ChucVu_IdChucVu",
                table: "NhanVien",
                column: "IdChucVu",
                principalTable: "ChucVu",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_Anh_idAnh",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_ChatLieu_idChatLieu",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_DeGiay_idDeGiay",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_KieuDang_idKieuDang",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_MauSac_idMauSac",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_NSX_idNSX",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_SanPham_idSanPham",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietGiay_Size_IdSize",
                table: "ChiTietGiay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietKhuyenMai_ChiTietGiay_idChiTietGiay",
                table: "ChiTietKhuyenMai");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietKhuyenMai_KhuyenMai_idKhuyenMai",
                table: "ChiTietKhuyenMai");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KhachHang_idKhachHang",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanVien_idNhanVien",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_SanPham_idSanPham",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonChiTiet_ChiTietGiay_idChiTietGiay",
                table: "HoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonChiTiet_HoaDon_idHoaDon",
                table: "HoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_ChucVu_IdChucVu",
                table: "NhanVien");

            migrationBuilder.DropTable(
                name: "HinhThucThanhToan");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_idSanPham",
                table: "HoaDon");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietKhuyenMai_idChiTietGiay",
                table: "ChiTietKhuyenMai");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietGiay_idAnh",
                table: "ChiTietGiay");

            migrationBuilder.DropColumn(
                name: "NgayNhanHang",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "NgayTraHang",
                table: "HoaDon");

            migrationBuilder.RenameColumn(
                name: "idSanPham",
                table: "HoaDon",
                newName: "idSanOham");

            migrationBuilder.RenameColumn(
                name: "idChiTietGiay",
                table: "ChiTietKhuyenMai",
                newName: "idHoaDonChiTiet");

            migrationBuilder.RenameColumn(
                name: "idAnh",
                table: "ChiTietGiay",
                newName: "IdAnh");

            migrationBuilder.RenameColumn(
                name: "trangThai",
                table: "Anh",
                newName: "TrangThai");

            migrationBuilder.RenameColumn(
                name: "tenAnh",
                table: "Anh",
                newName: "TenAnh");

            migrationBuilder.RenameColumn(
                name: "maAnh",
                table: "Anh",
                newName: "MaAnh");

            migrationBuilder.RenameColumn(
                name: "duongDan",
                table: "Anh",
                newName: "DuongDan");

            migrationBuilder.AlterDatabase(
                collation: "SQL_Latin1_General_CP1_CI_AS");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "Size",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "NSX",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "NhanVien",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "MauSac",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "KieuDang",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "KhachHang",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "idHoaDon",
                table: "HoaDonChiTiet",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ThanhTien",
                table: "HoaDonChiTiet",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DonGia",
                table: "HoaDonChiTiet",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdCongThuc",
                table: "HoaDonChiTiet",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "HoaDon",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GiamGia",
                table: "HoaDon",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "HoaDon",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "ChucVu",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "ChiTietGiay",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<string>(
                name: "Anh",
                table: "ChiTietGiay",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AnhsId",
                table: "ChiTietGiay",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ma",
                table: "ChatLieu",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "date", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "date", nullable: true),
                    Sdt = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    TenNguoiNhan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TinhTrang = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHangKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GioHangChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    DonGiaKhiGiam = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    IdChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet",
                        column: x => x.IdGioHang,
                        principalTable: "GioHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_ChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_idKhuyenMai",
                table: "HoaDonChiTiet",
                column: "idKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_AnhsId",
                table: "ChiTietGiay",
                column: "AnhsId");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_IdKhachHang",
                table: "GioHang",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_IdChiTietGiay",
                table: "GioHangChiTiet",
                column: "IdChiTietGiay");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_IdGioHang",
                table: "GioHangChiTiet",
                column: "IdGioHang");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_Anh_AnhsId",
                table: "ChiTietGiay",
                column: "AnhsId",
                principalTable: "Anh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_ChatLieu",
                table: "ChiTietGiay",
                column: "idChatLieu",
                principalTable: "ChatLieu",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_DeGiay",
                table: "ChiTietGiay",
                column: "idDeGiay",
                principalTable: "DeGiay",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_KieuDang",
                table: "ChiTietGiay",
                column: "idKieuDang",
                principalTable: "KieuDang",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_MauSac",
                table: "ChiTietGiay",
                column: "idMauSac",
                principalTable: "MauSac",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_NSX",
                table: "ChiTietGiay",
                column: "idNSX",
                principalTable: "NSX",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_SanPham",
                table: "ChiTietGiay",
                column: "idSanPham",
                principalTable: "SanPham",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietGiay_Size",
                table: "ChiTietGiay",
                column: "IdSize",
                principalTable: "Size",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietKhuyenMai_KhuyenMai",
                table: "ChiTietKhuyenMai",
                column: "idKhuyenMai",
                principalTable: "KhuyenMai",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KhachHang",
                table: "HoaDon",
                column: "idKhachHang",
                principalTable: "KhachHang",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanVien",
                table: "HoaDon",
                column: "idNhanVien",
                principalTable: "NhanVien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonChiTiet_ChiTietGiay",
                table: "HoaDonChiTiet",
                column: "idChiTietGiay",
                principalTable: "ChiTietGiay",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonChiTiet_ChiTietKhuyenMai",
                table: "HoaDonChiTiet",
                column: "idKhuyenMai",
                principalTable: "ChiTietKhuyenMai",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonChiTiet_HoaDon",
                table: "HoaDonChiTiet",
                column: "idHoaDon",
                principalTable: "HoaDon",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_ChucVu",
                table: "NhanVien",
                column: "IdChucVu",
                principalTable: "ChucVu",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
