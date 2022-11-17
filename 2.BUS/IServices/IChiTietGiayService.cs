using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChiTietGiayService
    {
        bool AddCTGiay(AddChiTietSPView obj);
        bool UpdateCTGiay(UpdateChiTietSPView obj);
        bool UpdateCTGiay2(ChiTietGiay obj);
        bool DeleteCTGiay(Guid IdCTSP);
        List<ViewChiTietGiay> GetViewChiTietGiay();
        List<ChiTietGiay> GetAllCTGiay();
        List<SanPhamCTView> GetAllSPView();
    }
}
