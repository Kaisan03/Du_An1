using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INhaSanXuatRepository
    {
        bool AddNSX(Nsx obj);
        bool UpdateNSX(Nsx obj);
        bool DeleteNSX(Nsx obj);
        List<Nsx> GetAllNSX();
    }
}
