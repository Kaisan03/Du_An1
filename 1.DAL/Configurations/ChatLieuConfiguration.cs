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
    public class ChatLieuConfiguration : IEntityTypeConfiguration<ChatLieu>
    {
        public void Configure(EntityTypeBuilder<ChatLieu> builder)
        {
            builder.ToTable("ChatLieu");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Ma).HasColumnType("nvarchar(10)");
            builder.Property(c => c.Ten).HasColumnType("nvarchar(50)");
            builder.Property(c => c.TrangThai).HasColumnType("int");
        }
    }
}
