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
    public class HinhThucThanhToanConfiguration : IEntityTypeConfiguration<HinhThucThanhToan>
    {
        public void Configure(EntityTypeBuilder<HinhThucThanhToan> builder)
        {
            builder.ToTable("HinhThucThanhToan");
            builder.HasKey(httt => httt.Id);
            builder.Property(httt => httt.Ma).HasColumnType("nvarchar(50)");
            builder.Property(httt => httt.NgayTao).HasColumnType("Datetime");
            builder.Property(httt => httt.NgaySua).HasColumnType("Datetime");
            builder.Property(httt => httt.LoaiHinhThanhToan).HasColumnType("int");
            builder.Property(httt => httt.TongTienThanhToan).HasColumnType("decimal(18,2)");
            builder.Property(httt => httt.TrangThai).HasColumnType("int");
            builder.HasOne(httt => httt.IdHoaDonNavigation).WithMany(hd => hd.HinhThucThanhToans).HasForeignKey(httt => httt.IdHoaDon);
        }
    }
}
