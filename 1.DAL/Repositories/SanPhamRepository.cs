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
    public class SanPhamRepository : ISanPhamRepository
    {
        private FpolyDBContext _dbContext;
        public SanPhamRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool AddSanPham(SanPham obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteSanPham(SanPham obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<SanPham> GetAllSanPham()
        {
            return _dbContext.SanPhams.ToList();
        }

        public bool UpdateSanPham(SanPham obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
