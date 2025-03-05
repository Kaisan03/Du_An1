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
    public class SanPhamConfiguration : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Ma).HasColumnType("nvarchar(50)");
            builder.Property(s => s.Ten).HasColumnType("nvarchar(50)");
            builder.Property(s => s.TrangThai).HasColumnType("int");
        }
    }
}
