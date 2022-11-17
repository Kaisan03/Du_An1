using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKieuDangService
    {
        bool AddKieuDang(KieuDang obj);
        bool UpdateKieuDang(KieuDang obj);
        bool DeleteKieuDang(KieuDang obj);
        List<KieuDang> GetAllKieuDang();
    }
}
