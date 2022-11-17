using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface INhanVienService
    {
        bool AddNhanVien(AddNhanVienView obj);
        bool UpdateNhanVien(UpdateNhanVienView obj);
        bool Delete(Guid IdNhanVien);
        List<NhanVien> GetAllNhanVien();
        List<ViewNhanVien> GetViewNhanVien();
       
    }
}
