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
    public class KhachHangConfiguration : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(kh => kh.Id);
            builder.Property(kh => kh.Ma).HasColumnType("nvarchar(10)");
            builder.Property(kh => kh.Ho).HasColumnType("nvarchar(50)");
            builder.Property(kh => kh.TenDem).HasColumnType("nvarchar(50)");
            builder.Property(kh => kh.Ten).HasColumnType("nvarchar(50)");
            builder.Property(kh => kh.NgaySinh).HasColumnType("date");
            builder.Property(kh => kh.Sdt).HasColumnType("nvarchar(50)");
            builder.Property(kh => kh.DiaChi).HasColumnType("nvarchar(100)");
            builder.Property(kh => kh.QuocGia).HasColumnType("nvarchar(50)");
            builder.Property(kh => kh.TrangThai).HasColumnType("int");
        }
    }
}
