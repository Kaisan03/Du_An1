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
    public class KhachHangRepository : IKhachHangRepository
    {

        private FpolyDBContext _dBContext;
        public KhachHangRepository()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(KhachHang obj)
        {


            _dBContext.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            _dBContext.Remove(obj);
            _dBContext.SaveChanges();
            return true;


        }

        public List<KhachHang> GetAll()
        {
            return _dBContext.KhachHangs.ToList();
        }

       

        public KhachHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;

            return _dBContext.KhachHangs.FirstOrDefault(s => s.Id == id);
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            var temobj = _dBContext.KhachHangs.FirstOrDefault(s => s.Id == obj.Id);
            temobj.Ma = obj.Ma;
            temobj.Ten = obj.Ten;
            temobj.TenDem = obj.TenDem;
            temobj.Ho = obj.Ho;
            temobj.NgaySinh = obj.NgaySinh;
            temobj.Sdt = obj.Sdt;
            temobj.DiaChi = obj.DiaChi;
            temobj.QuocGia = obj.QuocGia;
            temobj.TrangThai = obj.TrangThai;
            _dBContext.KhachHangs.Update(temobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
