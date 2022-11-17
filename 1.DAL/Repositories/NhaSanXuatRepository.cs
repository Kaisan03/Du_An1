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
    public class NhaSanXuatRepository : INhaSanXuatRepository
    {
        private FpolyDBContext _dbContext;
        public NhaSanXuatRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool AddNSX(Nsx obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteNSX(Nsx obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Nsx> GetAllNSX()
        {
            return _dbContext.Nsxes.ToList();
        }

        public bool UpdateNSX(Nsx obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
