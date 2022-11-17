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
    public class KhuyenMaiRepositpry : IKhuyenMaiRepository
    {
        private FpolyDBContext _dbContext;
        public KhuyenMaiRepositpry()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(KhuyenMai obj)
        {
           if(obj == null) return false;
            _dbContext.KhuyenMais.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhuyenMai obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.KhuyenMais.FirstOrDefault(c=>c .Id == obj.Id);
            _dbContext.KhuyenMais.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public List<KhuyenMai> GetAll()
        {
            return _dbContext.KhuyenMais.ToList();
        }

        public KhuyenMai GetByid(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.KhuyenMais.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(KhuyenMai obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.KhuyenMais.FirstOrDefault(c => c.Id == obj.Id);
            temp.Ma = obj.Ma;
            temp.Ten = obj.Ten;
            temp.Mota = obj.Mota;
            temp.TrangThai = obj.TrangThai;
            _dbContext.KhuyenMais.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
