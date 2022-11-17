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
    public class SizeRepository : ISizeRepository
    {
        private FpolyDBContext _dbContext;
        public SizeRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool AddSize(Size obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteSize(Size obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Size> GetAllSize()
        {
            return _dbContext.Sizes.ToList();
        }

        public bool UpdateSize(Size obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
