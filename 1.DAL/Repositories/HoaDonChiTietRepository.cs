using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonChiTietRepository : IHoaDonChiTietRipositry
    {
        public FpolyDBContext _dbConText;
        public HoaDonChiTietRepository()
        {
            _dbConText = new FpolyDBContext();
        }
        public bool Add(HoaDonChiTiet obj)
        {      
            _dbConText.Add(obj);
            _dbConText.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var temp = _dbConText.HoaDonChiTiets.FirstOrDefault(c => c.Id == obj.Id);
            _dbConText.HoaDonChiTiets.Remove(temp);
            _dbConText.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _dbConText.HoaDonChiTiets.ToList();
        }

        public HoaDonChiTiet GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbConText.HoaDonChiTiets.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(HoaDonChiTiet obj)
        {
           if(obj == null) return false;
           var temp = _dbConText.HoaDonChiTiets.FirstOrDefault(c=>c.Id == obj.Id);
            temp.SoLuong = obj.SoLuong;
            temp.DonGia = obj.DonGia;
            temp.ThanhTien = obj.ThanhTien;
            temp.TrangThai = obj.TrangThai;
            temp.IdChiTietGiay = obj.IdChiTietGiay;
            temp.IdHoaDon = obj.IdHoaDon;
            temp.IdTichDiem = obj.IdTichDiem;
            temp.IdKhuyenMai = obj.IdKhuyenMai;
            
            _dbConText.HoaDonChiTiets.Update(temp);
            _dbConText.SaveChanges();
            return true;
        }
    }
}
