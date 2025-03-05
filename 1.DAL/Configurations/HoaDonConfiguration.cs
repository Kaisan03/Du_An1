using _1.DAL.DomainClass;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(hd => hd.Id);
            builder.Property(hd => hd.Ma).HasColumnType("nvarchar(10)");
            builder.Property(hd => hd.TenSp).HasColumnType("nvarchar(50)");
            builder.Property(hd => hd.TenNguoiNhan).HasColumnType("nvarchar(50)");
            builder.Property(hd => hd.DiaChi).HasColumnType("nvarchar(100)");
            builder.Property(hd => hd.Sdt).HasColumnType("nvarchar(50)");
            builder.Property(hd => hd.GiamGia).HasColumnType("nvarchar(10)");
            builder.Property(hd => hd.GhiChu).HasColumnType("nvarchar(250)");
            builder.Property(hd => hd.TongTien).HasColumnType("decimal(18,2)");
            builder.Property(hd => hd.TienShip).HasColumnType("decimal(18,2)");
            builder.Property(hd => hd.TienCoc).HasColumnType("decimal(18,2)");
            builder.Property(hd => hd.TienKhachDua).HasColumnType("decimal(18,2)");
            builder.Property(hd => hd.TienMat).HasColumnType("decimal(18,2)");
            builder.Property(hd => hd.ChuyenKhoan).HasColumnType("decimal(18,2)");
            builder.Property(hd => hd.TrangThai).HasColumnType("int");
            builder.HasOne(hd => hd.IdCaNavigation).WithMany(gc => gc.HoaDons).HasForeignKey(hd => hd.IdCa);
            builder.HasOne(hd => hd.IdKhachHangNavigation).WithMany(kh => kh.HoaDons).HasForeignKey(hd => hd.IdKhachHang);
            builder.HasOne(hd => hd.IdNhanVienNavigation).WithMany(nv => nv.HoaDons).HasForeignKey(hd => hd.IdNhanVien);
            builder.HasOne(hd => hd.IdSanPhamNavigation).WithMany(sp => sp.HoaDons).HasForeignKey(hd => hd.IdSanPham);
        }
    }
}
