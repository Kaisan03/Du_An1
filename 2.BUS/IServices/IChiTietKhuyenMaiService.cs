using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChiTietKhuyenMaiService
    {
        bool Add(ChiTietKhuyenMai obj);
        bool Update(ChiTietKhuyenMai obj);
        bool Delete(ChiTietKhuyenMai obj);
        List<ChiTietKhuyenMai> GetAll();
    }
}
