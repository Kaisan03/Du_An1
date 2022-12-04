using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IGiaoCaService
    {
        bool Add(GiaoCa obj);
        bool Update(GiaoCa obj);
        bool Delete(GiaoCa obj);
        List<GiaoCa> GetAllGiaoca();
    }
}
