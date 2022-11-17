using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChiTietGiayRepository
    {
        bool AddChiTietGiay(ChiTietGiay obj);
        bool UpdateChiTietGiay(ChiTietGiay obj);
        bool DeleteChiTietGiay(ChiTietGiay obj);
        List<ChiTietGiay> GetAllChiTietGiay();
    }
}
