using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class SanPhamCTView
    {
        public Guid? IdCTSP { get; set; }
        public ChiTietGiay ChiTietGiay { get; set; }
        public SanPham SanPham { get; set; }
        public MauSac MauSac { get; set; }
        public Nsx Nsx { get; set; }
        public KieuDang KieuDang { get; set; }
        public Size Size { get; set; }
        public DeGiay DeGiay { get; set; }
        public ChatLieu ChatLieu { get; set; }
        public Anh Anh { get; set; }
    }
}
