using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class update_mavach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "NhanVien",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "HoaDon",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TongTien",
                table: "HoaDon",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaVach",
                table: "ChiTietGiay",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "TongTien",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "MaVach",
                table: "ChiTietGiay");
        }
    }
}
