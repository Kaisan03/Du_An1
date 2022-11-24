using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonService
    {
        string Add(ViewHoaDon obj);
        bool Update(HoaDon obj);
        string Delete(int obj);
        List<HoaDon> GetallHoadon();
        List<ViewHoaDon> GetAll();
    }
}
