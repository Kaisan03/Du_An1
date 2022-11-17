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
    public class NhanVienService : INhanVienService
    {
        private INhanVienRepository _iNhanVienRepository;
        private IChucVuRepository _ichucVuRepository;
        //private IHoaDonRepository _hoaDonRepository;
        private List<NhanVien> _lstNhanVien;
        private List<ViewNhanVien> _lstNhanVienView;
        
        public NhanVienService()
        {
            _iNhanVienRepository = new NhanVienRepository();
            _ichucVuRepository = new ChucVuRepository();
            //_hoaDonRepository = new HoaDonRepository();
        }

        

        public bool AddNhanVien(AddNhanVienView obj)
        {
            NhanVien nv = new NhanVien()
            {
                Id = Guid.NewGuid(),
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                IdChucVu = obj.IdChucVu,
                TrangThai = obj.TrangThai,
            };
            _iNhanVienRepository.Add(nv);
            return true;
        }

        
        public bool Delete(Guid IdNhanVien)
        {
            var x = _iNhanVienRepository.GetAllNhanVien().FirstOrDefault (p=> p.Id == IdNhanVien);
            _iNhanVienRepository.Delete(x);
            return true;
        }

    

        public bool UpdateNhanVien(UpdateNhanVienView obj)
        {
            var updateNv = _iNhanVienRepository.GetAllNhanVien().FirstOrDefault(c => c.Id == obj.Id);
            updateNv.IdChucVu = obj.IdChucVu;
            updateNv.Ma = obj.Ma;
            updateNv.Ten = obj.Ten;
            updateNv.DiaChi = obj.DiaChi;
            updateNv.NgaySinh = obj.NgaySinh;
            updateNv.TrangThai = obj.TrangThai;
            _iNhanVienRepository.Update(updateNv);
            return true;
            //var vnv = new NhanVien()
            //{
            //    Id = Guid.NewGuid(),
            //    Ma = obj.Ma,
            //    Ten = obj.Ten,
            //    TenDem = obj.TenDem,
            //    Ho = obj.Ho,
            //    GioiTinh = obj.GioiTinh,
            //    NgaySinh = obj.NgaySinh,
            //    DiaChi = obj.DiaChi,
            //    Sdt = obj.Sdt,
            //    MatKhau = obj.MatKhau,
            //    IdChucVu = obj.IdChucVu,
            //    TrangThai = obj.TrangThai,
            //};
            //_iNhanVienRepository.Update(vnv);
            //return true;
        }

       

        public List<ViewNhanVien> GetViewNhanVien()
        {
            _lstNhanVienView = (from nv in _iNhanVienRepository.GetAllNhanVien()
                                join cv in _ichucVuRepository.GetAllChucVu() on nv.IdChucVu equals cv.Id
                                select new ViewNhanVien()
                                {
                                    Id = nv.Id,
                                    TenChuCVu = cv.Ten,
                                    IdChucVu = nv.IdChucVu,
                                    Ma = nv.Ma,
                                    Ten = nv.Ten,
                                    TenDem = nv.TenDem,
                                    Ho = nv.Ho,
                                    GioiTinh = nv.GioiTinh,
                                    NgaySinh = nv.NgaySinh,
                                    DiaChi = nv.DiaChi,
                                    Sdt = nv.Sdt,
                                    MatKhau = nv.MatKhau,
                                    TrangThai = nv.TrangThai,
                                }).ToList();
            return _lstNhanVienView;
            //List<ViewNhanVien> _lstNhanVien = new List<ViewNhanVien>();
            //_lstNhanVien = (from nv in _iNhanVienRepository.GetAll()
            //                join cv in _ichucVuRepository.GetAllChucVu() on nv.IdChucVu equals cv.Id
            //                select new ViewNhanVien
            //                {
            //                    Id = nv.Id,
            //                    Ma = nv.Ma,
            //                    Ten = nv.Ten,
            //                    TenDem = nv.TenDem,
            //                    Ho = nv.Ho,
            //                    GioiTinh = nv.GioiTinh,
            //                    NgaySinh = nv.NgaySinh,
            //                    DiaChi = nv.DiaChi,
            //                    Sdt = nv.Sdt,
            //                    MatKhau = nv.MatKhau,
            //                    IdChucVu = nv.IdChucVu,
            //                    TrangThai = nv.TrangThai

            //                }).ToList();
            //return _lstNhanVienView;
        }

        public List<NhanVien> GetAllNhanVien()
        {
            return _iNhanVienRepository.GetAllNhanVien();
        }
    }
   
}
