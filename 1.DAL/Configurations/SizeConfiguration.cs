using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.Configurations
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.ToTable("Size");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Ma).HasColumnType("nvarchar(10)");
            builder.Property(s => s.Ten).HasColumnType("nvarchar(50)");
            builder.Property(s => s.TrangThai).HasColumnType("int");
        }
    }
}
