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
    public class NsxConfiguration : IEntityTypeConfiguration<Nsx>
    {
        public void Configure(EntityTypeBuilder<Nsx> builder)
        {
            builder.ToTable("NSX");
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Ma).HasColumnType("nvarchar(10)");
            builder.Property(n => n.Ten).HasColumnType("nvarchar(50)");
            builder.Property(n => n.TrangThai).HasColumnType("int");
        }
    }
}
