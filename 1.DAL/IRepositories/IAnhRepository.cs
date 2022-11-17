using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IAnhRepository
    {
        bool AddAnh(Anh obj);
        bool UpdateAnh(Anh obj);
        bool DeleteAnh(Anh obj);
        List<Anh> GetAllAnh();
    }
}
