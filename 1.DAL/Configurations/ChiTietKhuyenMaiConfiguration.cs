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
    public class ChiTietKhuyenMaiConfiguration : IEntityTypeConfiguration<ChiTietKhuyenMai>
    {
        public void Configure(EntityTypeBuilder<ChiTietKhuyenMai> builder)
        {
            builder.ToTable("ChiTietKhuyenMai");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.TrangThai).HasColumnType("int");
            builder.HasOne(c => c.IdKhuyenMaiNavigation).WithMany(km => km.ChiTietKhuyenMais).HasForeignKey(c => c.IdKhuyenMai);
            builder.HasOne(c => c.IdChiTietGiayNavigation).WithMany(ctg => ctg.ChiTietKhuyenMais).HasForeignKey(c => c.IdChiTietGiay);
        }
    }
}
