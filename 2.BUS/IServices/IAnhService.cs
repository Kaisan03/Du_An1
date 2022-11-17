using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IAnhService
    {
        bool AddAnh(Anh obj);
        bool UpdateAnh(Anh obj);
        bool DeleteAnh(Anh obj);
        List<Anh> GetAllAnh();
    }
}
