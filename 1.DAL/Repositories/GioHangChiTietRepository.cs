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
    public class GioHangChiTietRepository : IGioHangChiTietRepository
    {
        private FpolyDBContext _dbContext;
        public GioHangChiTietRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        public bool AddGioHangCT(GioHangChiTiet obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteGioHangCT(GioHangChiTiet obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<GioHangChiTiet> GetAllGioHangCT()
        {
            return _dbContext.GioHangChiTiets.ToList();
        }

        public bool UpdateGioHangCT(GioHangChiTiet obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
