using _1.DAL.DomainClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    public class AnhConfiguration : IEntityTypeConfiguration<Anh>
    {
        public void Configure(EntityTypeBuilder<Anh> builder)
        {
            builder.ToTable("Anh");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.MaAnh).HasColumnType("nvarchar(50)");
            builder.Property(c => c.TenAnh).HasColumnType("nvarchar(100)");
            builder.Property(c => c.DuongDan).HasColumnType("nvarchar(50)");
            builder.Property(c => c.TrangThai).HasColumnType("int");
        }
    }
}
