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
    public class ChiTietGiayService : IChiTietGiayService
    {
        private IChiTietGiayRepository _IChiTietGiayRepository;
        private List<SanPhamCTView> _lstSanPhamCTView;
        private List<ViewChiTietGiay> _lstViewChiTietGiay;
        private List<ChiTietGiay> _lsttChiTietGiay;
        private IChatLieuRepository _IChatLieuRepository;
        private IMauSacRepository _IMauSacRepository;
        private INhaSanXuatRepository _INsxRepository;
        private IKieuDangRepository _IKieuDangRepository;
        private IDeGiayRepository _IDeGiayRepository;
        private ISizeRepository _ISizeRepository;
        private ISanPhamRepository _ISanPhamRepository;
        private IAnhRepository _IAnhRepository;
        public ChiTietGiayService()
        {
            _IChiTietGiayRepository = new ChiTietGiayRepository();
            _lstViewChiTietGiay = new List<ViewChiTietGiay>();
            _lsttChiTietGiay = new List<ChiTietGiay>();
            _IChatLieuRepository = new ChatLieuRepository();
            _IMauSacRepository = new MauSacRepository();
            _INsxRepository = new NhaSanXuatRepository();
            _IKieuDangRepository = new KieuDangRepository();
            _IDeGiayRepository = new DeGiayRepository();
            _ISizeRepository = new SizeRepository();
            _ISanPhamRepository = new SanPhamRepository();
            _IAnhRepository = new AnhRepository();
            _lstSanPhamCTView = new List<SanPhamCTView>();
        }

        public bool AddCTGiay(AddChiTietSPView obj)
        {
            ChiTietGiay ctsp = new ChiTietGiay()
            {
                Id = Guid.NewGuid(),
                IdSanPham = obj.IdSP,
                IdChatLieu = obj.IdChatLieu,
                IdMauSac = obj.IdMauSac,
                IdNsx = obj.IdNsx,
                IdDeGiay = obj.IdDeGiay,
                IdSize = obj.IdSize,
                IdKieuDang = obj.IdKieuDang,
                Ma = obj.Ma,
                IdAnh = obj.IdAnh,
                SoLuong = obj.SoLuong,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                SoLuongTon = obj.SoLuongTon,
                TrangThai = obj.TrangThai,
                MoTa = obj.MoTa
            };
            _IChiTietGiayRepository.AddChiTietGiay(ctsp);
            return true;
        }

        public bool DeleteCTGiay(Guid IdCTSP)
        {
            var x = _IChiTietGiayRepository.GetAllChiTietGiay().FirstOrDefault(p => p.Id == IdCTSP);
            
            _IChiTietGiayRepository.DeleteChiTietGiay(x);
            return true;

        }

        public bool UpdateCTGiay(UpdateChiTietSPView obj)
        {
            var x = _IChiTietGiayRepository.GetAllChiTietGiay().FirstOrDefault(p => p.Id == obj.Id);
            x.IdSanPham = obj.IdSP;
            x.IdChatLieu = obj.IdChatLieu;
            x.IdMauSac = obj.IdMauSac;
            x.IdNsx = obj.IdNsx;
            x.IdDeGiay = obj.IdDeGiay;
            x.IdSize = obj.IdSize;
            x.IdKieuDang = obj.IdKieuDang;
            x.Ma = obj.Ma;
            x.IdAnh = obj.IdAnh;
            x.SoLuong = obj.SoLuong;
            x.GiaNhap = obj.GiaNhap;
            x.GiaBan = obj.GiaBan;
            x.SoLuongTon = obj.SoLuongTon;
            x.TrangThai = obj.TrangThai;
            x.MoTa = obj.MoTa;
            _IChiTietGiayRepository.UpdateChiTietGiay(x);
            return true;
        }

        public List<ChiTietGiay> GetAllCTGiay()
        {
            return _IChiTietGiayRepository.GetAllChiTietGiay();
        }

        public List<ViewChiTietGiay> GetViewChiTietGiay()
        {
            _lstViewChiTietGiay = (from ctsp in _IChiTietGiayRepository.GetAllChiTietGiay()
                                   join chatlieu in _IChatLieuRepository.GetAllChatLieu() on ctsp.IdChatLieu equals chatlieu.Id
                                   join mausac in _IMauSacRepository.GetAllMauSac() on ctsp.IdMauSac equals mausac.Id
                                   join nsx in _INsxRepository.GetAllNSX() on ctsp.IdNsx equals nsx.Id
                                   join kieudang in _IKieuDangRepository.GetAllKieuDang() on ctsp.IdKieuDang equals kieudang.Id
                                   join degiay in _IDeGiayRepository.GetAllDeGiay() on ctsp.IdDeGiay equals degiay.Id
                                   join size in _ISizeRepository.GetAllSize() on ctsp.IdSize equals size.Id
                                   join sp in _ISanPhamRepository.GetAllSanPham() on ctsp.IdSanPham equals sp.Id
                                   join anh in _IAnhRepository.GetAllAnh() on ctsp.IdAnh equals anh.Id
                                   select new ViewChiTietGiay
                                   {
                                      Id = ctsp.Id,
                                      TenChatLieu = chatlieu.Ten,
                                      TenMauSac = mausac.Ten,
                                      TenNSX = nsx.Ten,
                                      TenKieuDang = kieudang.Ten,
                                      TenDeGiay = degiay.Ten,
                                      TenSize = size.Ten,
                                      TenSanPham = sp.Ten,
                                      Ma = ctsp.Ma,
                                      Anh = anh.TenAnh,
                                      SoLuong = ctsp.SoLuong,
                                      GiaBan = ctsp.GiaBan,
                                      GiaNhap = ctsp.GiaNhap,
                                      SoLuongTon = ctsp.SoLuongTon,
                                      TrangThai = ctsp.TrangThai,
                                      MoTa = ctsp.MoTa
                                   }).ToList();
            return _lstViewChiTietGiay;
        }

        public List<SanPhamCTView> GetAllSPView()
        {
            _lstSanPhamCTView = (from ctsp in _IChiTietGiayRepository.GetAllChiTietGiay()
                                   join chatlieu in _IChatLieuRepository.GetAllChatLieu() on ctsp.IdChatLieu equals chatlieu.Id
                                   join mausac in _IMauSacRepository.GetAllMauSac() on ctsp.IdMauSac equals mausac.Id
                                   join nsx in _INsxRepository.GetAllNSX() on ctsp.IdNsx equals nsx.Id
                                   join kieudang in _IKieuDangRepository.GetAllKieuDang() on ctsp.IdKieuDang equals kieudang.Id
                                   join degiay in _IDeGiayRepository.GetAllDeGiay() on ctsp.IdDeGiay equals degiay.Id
                                   join size in _ISizeRepository.GetAllSize() on ctsp.IdSize equals size.Id
                                   join sp in _ISanPhamRepository.GetAllSanPham() on ctsp.IdSanPham equals sp.Id
                                   join anh in _IAnhRepository.GetAllAnh() on ctsp.IdAnh equals anh.Id

                                   select new SanPhamCTView
                                   {
                                       ChiTietGiay= ctsp,
                                       IdCTSP = ctsp.Id,
                                       ChatLieu = chatlieu,
                                       MauSac = mausac,
                                       Nsx = nsx,
                                       KieuDang = kieudang,
                                       DeGiay = degiay,
                                       Size = size,
                                       SanPham = sp,
                                       Anh = anh
                                       
                                   }).ToList();
            return _lstSanPhamCTView;
        }

        public bool UpdateCTGiay2(ChiTietGiay obj)
        {
            _IChiTietGiayRepository.UpdateChiTietGiay(obj);
            return true;
        }
    }
}
