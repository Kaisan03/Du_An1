using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChucVuRepository
    {
        bool AddChucVu(ChucVu obj);
        bool UpdateChucVu(ChucVu obj);

        bool DeleteChucVu(ChucVu obj);
       
        List<ChucVu> GetAllChucVu();

    }
}
