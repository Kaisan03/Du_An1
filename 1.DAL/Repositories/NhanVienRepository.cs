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
    public class NhanVienRepository :INhanVienRepository
    {
        private FpolyDBContext _dBContext;
        public NhanVienRepository()
        {
            _dBContext  = new FpolyDBContext();
        }

        public bool Add(NhanVien obj)
        {
            _dBContext.NhanViens.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            //var ob = _dBContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            _dBContext.Remove(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAllNhanVien()
        {
           return _dBContext.NhanViens.ToList();
        }

        //public NhanVien GetByid(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        public bool Update(NhanVien obj)
        {
            _dBContext.Update(obj);
            _dBContext.SaveChanges();
            return true;
            //var ob = _dBContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            //ob.Id = obj.Id;
            //ob.Ma=obj.Ma;
            //ob.Ho=obj.Ho;
            //ob.TenDem=obj.TenDem;
            //ob.Ten=obj.Ten;
            //ob.GioiTinh=obj.GioiTinh;
            //ob.NgaySinh=obj.NgaySinh;
            //ob.DiaChi=obj.DiaChi;
            //ob.MatKhau=obj.MatKhau;
            //ob.IdChucVu=obj.IdChucVu;
            //obj.TrangThai=obj.TrangThai;
            //_dBContext.NhanViens.Remove(ob);
            //_dBContext.SaveChanges();
            //return true;
        }
    }
}
