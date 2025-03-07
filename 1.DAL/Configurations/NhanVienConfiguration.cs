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
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(nv => nv.Id);
            builder.Property(nv => nv.Ma).HasColumnType("nvarchar(10)");
            builder.Property(nv => nv.Ho).HasColumnType("nvarchar(50)");
            builder.Property(nv => nv.TenDem).HasColumnType("nvarchar(50)");
            builder.Property(nv => nv.Ten).HasColumnType("nvarchar(50)");
            builder.Property(nv => nv.GioiTinh).HasColumnType("nvarchar(50)");
            builder.Property(nv => nv.NgaySinh).HasColumnType("Datetime");
            builder.Property(nv => nv.DiaChi).HasColumnType("nvarchar(100)");
            builder.Property(nv => nv.Sdt).HasColumnType("nvarchar(50)");
            builder.Property(nv => nv.Email).HasColumnType("nvarchar(60)");
            builder.Property(nv => nv.DuongDan).HasColumnType("nvarchar(100)");
            builder.Property(nv => nv.MatKhau).HasColumnType("nvarchar(50)");
            builder.Property(nv => nv.TrangThai).HasColumnType("int");
            builder.HasOne(nv => nv.IdChucVuNavigation).WithMany(cv => cv.NhanViens).HasForeignKey(nv => nv.IdChucVu);
        }
    }
}
