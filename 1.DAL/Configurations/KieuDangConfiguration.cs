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
    public class KieuDangConfiguration : IEntityTypeConfiguration<KieuDang>
    {
        public void Configure(EntityTypeBuilder<KieuDang> builder)
        {
            builder.ToTable("KieuDang");
            builder.HasKey(k => k.Id);
            builder.Property(k => k.Ma).HasColumnType("nvarchar(10)");
            builder.Property(k => k.Ten).HasColumnType("nvarchar(50)");
            builder.Property(k => k.TrangThai).HasColumnType("int");
        }
    }
}
