using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class GioHangService : IGioHangService
    {
        private IGioHangRepository _IGioHangRepository;
        private IKhachHangRepository _IKhachHangRepository;
        private INhanVienRepository _INhanVienRepository;
        private List<ViewGioHangcs> _lstViewGioHang;
        public GioHangService()
        {
            _IGioHangRepository = new GioHangRepository();
            _IKhachHangRepository = new KhachHangRepository();
            _INhanVienRepository = new NhanVienRepository();

        }
        public bool AddGH(GioHang obj)
        {
            _IGioHangRepository.AddGioHang(obj);
            return true;
        }

        

        public bool DeleteGH(GioHang obj)
        {
            _IGioHangRepository.DeleteGioHang(obj);
            return true;
        }

        

        public List<GioHang> GetAllGH()
        {
            return _IGioHangRepository.GetAllGioHang();
        }

        public List<ViewGioHangcs> GetViewGioHang()
        {
            //_lstViewGioHang = (from gh in GetAllGH()
            //                   join kh in _IKhachHangRepository.GetAllKhachHang() on gh.IdKh equals kh.Id
            //                   join nv in _INhanVienRepository.GetAllNhanVien() on gh.IdNv equals nv.Id
            //                   select new GioHangView()
            //                   {
            //                       GioHang = gh,
            //                       KhachHang = kh,
            //                       NhanVien = nv
            //                   }).ToList();
            return _lstViewGioHang;
        }

        public bool UpdateGH(GioHang obj)
        {
            _IGioHangRepository.UpdateGioHang(obj);
            return true;
        }

        
        

        
    }
}
