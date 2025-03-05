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
    public class KhuyenMaiConfiguration : IEntityTypeConfiguration<KhuyenMai>
    {
        public void Configure(EntityTypeBuilder<KhuyenMai> builder)
        {
            builder.ToTable("KhuyenMai");
            builder.HasKey(km => km.Id);
            builder.Property(km => km.Ma).HasColumnType("nvarchar(50)");
            builder.Property(km => km.Ten).HasColumnType("nvarchar(50)");
            builder.Property(km => km.Mota).HasColumnType("nvarchar(50)");
            builder.Property(km => km.TrangThai).HasColumnType("int");
        }
    }
}
