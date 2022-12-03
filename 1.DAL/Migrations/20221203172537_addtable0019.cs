using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class addtable0019 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiaoCa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNhanVienTrongCa = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVienTiepTheo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThoiGianNhanCa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianGiaoCa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TienBatDauCa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTienMat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTienTrongCa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTienKhac = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongTienPhatSinh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GhiChuPhatSinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongTienMatCaTruoc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThoiGianReset = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdChuCuaHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TongTienMatRut = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoCa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiaoCa_NhanVien_IdNhanVienTrongCa",
                        column: x => x.IdNhanVienTrongCa,
                        principalTable: "NhanVien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_IdNhanVienTrongCa",
                table: "GiaoCa",
                column: "IdNhanVienTrongCa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiaoCa");
        }
    }
}
