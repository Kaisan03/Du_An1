using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISanPhamRepository
    {
        bool AddSanPham(SanPham obj);
        bool UpdateSanPham(SanPham obj);
        bool DeleteSanPham(SanPham obj);
        List<SanPham> GetAllSanPham();
    }
}
