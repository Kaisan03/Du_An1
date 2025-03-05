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
    public class HoaDonChiTietConfiguration : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(hdct => hdct.Id);
            builder.Property(hdct => hdct.DonGia).HasColumnType("decimal(18,0)");
            builder.Property(hdct => hdct.ThanhTien).HasColumnType("decimal(18,0)");
            builder.Property(hdct => hdct.TrangThai).HasColumnType("int");
            builder.HasOne(hdct => hdct.IdChiTietGiayNavigation).WithMany(ctg => ctg.HoaDonChiTiets).HasForeignKey(hdct => hdct.IdChiTietGiay);
            builder.HasOne(hdct => hdct.IdHoaDonNavigation).WithMany(hd => hd.HoaDonChiTiets).HasForeignKey(hdct => hdct.IdHoaDon);
        }
    }
}
