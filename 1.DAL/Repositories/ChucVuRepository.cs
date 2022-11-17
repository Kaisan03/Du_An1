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
  
    public class ChucVuRepository : IChucVuRepository
    {
        private FpolyDBContext _dBContxet;
        public ChucVuRepository()
        {
            _dBContxet = new FpolyDBContext();
        }

        public bool AddChucVu(ChucVu obj)
        {
            _dBContxet.ChucVus.Add(obj);
            _dBContxet.SaveChanges();
            return true;
        }

        public bool DeleteChucVu(ChucVu obj)
        {
            var tem = _dBContxet.ChucVus.FirstOrDefault(c=> c.Id == obj.Id);
            _dBContxet.ChucVus.Remove(tem);
            _dBContxet.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAllChucVu()
        {
           return _dBContxet.ChucVus.ToList();
        }

        public bool UpdateChucVu(ChucVu obj)
        {
            var tem = _dBContxet.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
            tem.Ma = obj.Ma;
            tem.Ten = obj.Ten;
            tem.TrangThai = obj.TrangThai;
            _dBContxet.ChucVus.Update(tem);
            _dBContxet.SaveChanges();
            return true;
        }
    }
}
