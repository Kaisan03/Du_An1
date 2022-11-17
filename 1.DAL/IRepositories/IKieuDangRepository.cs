using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKieuDangRepository
    {
        bool AddKieuDang(KieuDang obj);
        bool UpdateKieuDang(KieuDang obj);
        bool DeleteKieuDang(KieuDang obj);
        List<KieuDang> GetAllKieuDang();
    }
}
