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
    public class GiaoCaConfiguration : IEntityTypeConfiguration<GiaoCa>
    {
        public void Configure(EntityTypeBuilder<GiaoCa> builder)
        {
            builder.ToTable("GiaoCa");
            builder.HasKey(gc => gc.Id);
            builder.Property(gc => gc.Ma).HasColumnType("nvarchar(50)");
            builder.Property(gc => gc.TienBatDauCa).HasColumnType("decimal(18,2)");
            builder.Property(gc => gc.TongTienMat).HasColumnType("decimal(18,2)");
            builder.Property(gc => gc.TongTienTrongCa).HasColumnType("decimal(18,2)");
            builder.Property(gc => gc.TongTienKhac).HasColumnType("decimal(18,2)");
            builder.Property(gc => gc.TongTienPhatSinh).HasColumnType("decimal(18,2)");
            builder.Property(gc => gc.GhiChuPhatSinh).HasColumnType("nvarchar(500)");
            builder.Property(gc => gc.TongTienMatCaTruoc).HasColumnType("decimal(18,2)");
            builder.Property(gc => gc.TongTienMatRut).HasColumnType("decimal(18,2)");
            builder.Property(gc => gc.TrangThai).HasColumnType("int");
            builder.HasOne(gc => gc.IdNhanViennNavigation).WithMany(nv => nv.GiaoCas).HasForeignKey(gc => gc.IdNhanVienTrongCa);
        }
    }
}
