using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IMauSacRepository
    {
        bool AddMauSac(MauSac obj);
        bool UpdateMauSac(MauSac obj);
        bool DeleteMauSac(MauSac obj);
        List<MauSac> GetAllMauSac();
    }
}
