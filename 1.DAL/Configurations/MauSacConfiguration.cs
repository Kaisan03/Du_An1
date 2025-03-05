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
    public class MauSacConfiguration : IEntityTypeConfiguration<MauSac>
    {
        public void Configure(EntityTypeBuilder<MauSac> builder)
        {
            builder.ToTable("MauSac");
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Ma).HasColumnType("nvarchar(10)");
            builder.Property(m => m.Ten).HasColumnType("nvarchar(50)");
            builder.Property(m => m.TrangThai).HasColumnType("int");
        }
    }
}
