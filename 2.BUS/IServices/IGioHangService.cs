using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IGioHangService
    {
        bool AddGH(GioHang obj);
        bool UpdateGH(GioHang obj);
        bool DeleteGH(GioHang obj);
        List<GioHang> GetAllGH();
        List<ViewGioHangcs> GetViewGioHang();
    }
}
