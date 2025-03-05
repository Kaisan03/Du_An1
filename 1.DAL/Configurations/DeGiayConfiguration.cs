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
    public class DeGiayConfiguration : IEntityTypeConfiguration<DeGiay>
    {
        public void Configure(EntityTypeBuilder<DeGiay> builder)
        {
            builder.ToTable("DeGiay");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Ma).HasColumnType("nvarchar(50)");
            builder.Property(d => d.Ten).HasColumnType("nvarchar(50)");
            builder.Property(d => d.ChatLieu).HasColumnType("nvarchar(50)");
            builder.Property(d => d.ChieuCao).HasColumnType("int");
            builder.Property(d => d.TrangThai).HasColumnType("int");
        }
    }
}
