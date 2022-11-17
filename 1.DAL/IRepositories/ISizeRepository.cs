using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISizeRepository
    {
        bool AddSize(Size obj);
        bool UpdateSize(Size obj);
        bool DeleteSize(Size obj);
        List<Size> GetAllSize();
    }
}
