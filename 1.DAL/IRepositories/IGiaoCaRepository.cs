using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGiaoCaRepository
    {
        bool Add(GiaoCa obj);
        bool Delete(GiaoCa obj);
        bool Update(GiaoCa obj);
        List<GiaoCa> GetAll();
    }
}
