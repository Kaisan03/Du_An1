using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class aaaaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anh",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    maAnh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tenAnh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    duongDan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChatLieu",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLieu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DeGiay",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChatLieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChieuCao = table.Column<int>(type: "int", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeGiay", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Ho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenDem = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    QuocGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "KieuDang",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuDang", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NSX",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NSX", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Ho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenDem = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GioiTInh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgaySInh = table.Column<DateTime>(type: "date", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdChucVu",
                        column: x => x.IdChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietGiay",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IdSize = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idNSX = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idKieuDang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    GiaNhap = table.Column<int>(type: "int", nullable: true),
                    GiaBan = table.Column<int>(type: "int", nullable: true),
                    SoLuongTon = table.Column<int>(type: "int", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    idSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idDeGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idAnh = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietGiay", x => x.id);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_Anh_idAnh",
                        column: x => x.idAnh,
                        principalTable: "Anh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_ChatLieu_idChatLieu",
                        column: x => x.idChatLieu,
                        principalTable: "ChatLieu",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_DeGiay_idDeGiay",
                        column: x => x.idDeGiay,
                        principalTable: "DeGiay",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_KieuDang_idKieuDang",
                        column: x => x.idKieuDang,
                        principalTable: "KieuDang",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_MauSac_idMauSac",
                        column: x => x.idMauSac,
                        principalTable: "MauSac",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_NSX_idNSX",
                        column: x => x.idNSX,
                        principalTable: "NSX",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_SanPham_idSanPham",
                        column: x => x.idSanPham,
                        principalTable: "SanPham",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiay_Size_IdSize",
                        column: x => x.IdSize,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                       
                    idKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TenSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "date", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "date", nullable: true),
                    NgayGiao = table.Column<DateTime>(type: "date", nullable: true),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GiamGia = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    idSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayNhanHang = table.Column<DateTime>(type: "date", nullable: true),
                    NgayTraHang = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_idKhachHang",
                        column: x => x.idKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_idNhanVien",
                        column: x => x.idNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_SanPham_idSanPham",
                        column: x => x.idSanPham,
                        principalTable: "SanPham",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietKhuyenMai",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    idChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietKhuyenMai", x => x.id);
                    table.ForeignKey(
                        name: "FK_ChiTietKhuyenMai_ChiTietGiay_idChiTietGiay",
                        column: x => x.idChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietKhuyenMai_KhuyenMai_idKhuyenMai",
                        column: x => x.idKhuyenMai,
                        principalTable: "KhuyenMai",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idHoaDon = table.Column<int>(type: "int", nullable: false),
                    idTichDIem = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    DonGia = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.id);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ChiTietGiay_idChiTietGiay",
                        column: x => x.idChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_idHoaDon",
                        column: x => x.idHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatLieu",
                table: "ChatLieu",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_idAnh",
                table: "ChiTietGiay",
                column: "idAnh");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_idChatLieu",
                table: "ChiTietGiay",
                column: "idChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_idDeGiay",
                table: "ChiTietGiay",
                column: "idDeGiay");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_idKieuDang",
                table: "ChiTietGiay",
                column: "idKieuDang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_idMauSac",
                table: "ChiTietGiay",
                column: "idMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_idNSX",
                table: "ChiTietGiay",
                column: "idNSX");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_idSanPham",
                table: "ChiTietGiay",
                column: "idSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdSize",
                table: "ChiTietGiay",
                column: "IdSize");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKhuyenMai_idChiTietGiay",
                table: "ChiTietKhuyenMai",
                column: "idChiTietGiay");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietKhuyenMai_idKhuyenMai",
                table: "ChiTietKhuyenMai",
                column: "idKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_idKhachHang",
                table: "HoaDon",
                column: "idKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_idNhanVien",
                table: "HoaDon",
                column: "idNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_idSanPham",
                table: "HoaDon",
                column: "idSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_idChiTietGiay",
                table: "HoaDonChiTiet",
                column: "idChiTietGiay");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_idHoaDon",
                table: "HoaDonChiTiet",
                column: "idHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdChucVu",
                table: "NhanVien",
                column: "IdChucVu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietKhuyenMai");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "ChiTietGiay");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "Anh");

            migrationBuilder.DropTable(
                name: "ChatLieu");

            migrationBuilder.DropTable(
                name: "DeGiay");

            migrationBuilder.DropTable(
                name: "KieuDang");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "NSX");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
