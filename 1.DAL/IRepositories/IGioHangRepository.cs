using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGioHangRepository
    {
        bool AddGioHang(GioHang obj);
        bool UpdateGioHang(GioHang obj);
        bool DeleteGioHang(GioHang obj);
        List<GioHang> GetAllGioHang();
    }
}
