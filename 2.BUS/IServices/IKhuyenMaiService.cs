using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKhuyenMaiService
    {
        bool Add(KhuyenMai obj);
        bool Update(KhuyenMai obj);
        bool DeleteD(KhuyenMai obj);
        List<KhuyenMai> GetAllKhuyenMai();
    }
}
