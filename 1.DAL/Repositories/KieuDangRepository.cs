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
    public class KieuDangRepository : IKieuDangRepository
    {
        private FpolyDBContext _dbContext;
        public KieuDangRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool AddKieuDang(KieuDang obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteKieuDang(KieuDang obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<KieuDang> GetAllKieuDang()
        {
            return _dbContext.KieuDangs.ToList();
        }

        public bool UpdateKieuDang(KieuDang obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
