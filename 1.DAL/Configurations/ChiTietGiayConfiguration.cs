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
    public class ChiTietGiayConfiguration : IEntityTypeConfiguration<ChiTietGiay>
    {
        public void Configure(EntityTypeBuilder<ChiTietGiay> builder)
        {
            builder.ToTable("ChiTietGiay");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Ma).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(c => c.SoLuong).HasColumnType("int");
            builder.Property(c => c.MaVach).HasColumnType("nvarchar(200)");
            builder.Property(c => c.GiaNhap).HasColumnType("int");
            builder.Property(c => c.GiaBan).HasColumnType("int");
            builder.Property(c => c.SoLuongTon).HasColumnType("int");
            builder.Property(c => c.TrangThai).HasColumnType("int");
            builder.Property(c => c.MoTa).HasColumnType("nvarchar(100)");
            builder.HasOne(c => c.IdAnhNavigation).WithMany(a => a.ChiTietGiays).HasForeignKey(c => c.IdAnh);
            builder.HasOne(c => c.IdChatLieuNavigation).WithMany(cl => cl.ChiTietGiays).HasForeignKey(c => c.IdChatLieu);
            builder.HasOne(c => c.IdDeGiayNavigation).WithMany(dg => dg.ChiTietGiays).HasForeignKey(c => c.IdDeGiay);
            builder.HasOne(c => c.IdKieuDangNavigation).WithMany(kd => kd.ChiTietGiays).HasForeignKey(c => c.IdKieuDang);
            builder.HasOne(c => c.IdMauSacNavigation).WithMany(ms => ms.ChiTietGiays).HasForeignKey(c => c.IdMauSac);
            builder.HasOne(c => c.IdNsxNavigation).WithMany(nsx => nsx.ChiTietGiays).HasForeignKey(c => c.IdNsx);
            builder.HasOne(c => c.IdSanPhamNavigation).WithMany(sp => sp.ChiTietGiays).HasForeignKey(c => c.IdSanPham);
            builder.HasOne(c => c.IdSizeNavigation).WithMany(sz => sz.ChiTietGiays).HasForeignKey(c => c.IdSize);
        }
    }
}
