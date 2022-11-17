using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGioHangChiTietRepository
    {
        bool AddGioHangCT(GioHangChiTiet obj);
        bool UpdateGioHangCT(GioHangChiTiet obj);
        bool DeleteGioHangCT(GioHangChiTiet obj);
        List<GioHangChiTiet> GetAllGioHangCT();
    }
}
