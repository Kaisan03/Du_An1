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
    public class GioHangRepository : IGioHangRepository
    {
        private FpolyDBContext _dbContext;
        public GioHangRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        public bool AddGioHang(GioHang obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteGioHang(GioHang obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<GioHang> GetAllGioHang()
        {
            return _dbContext.GioHangs.ToList();
        }

        public bool UpdateGioHang(GioHang obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
