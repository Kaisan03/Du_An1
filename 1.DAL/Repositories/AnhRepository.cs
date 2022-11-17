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
    public class AnhRepository : IAnhRepository
    {
        private FpolyDBContext _dbContext;
        public AnhRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool AddAnh(Anh obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteAnh(Anh obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Anh> GetAllAnh()
        {
            return _dbContext.Anhs.ToList();
        }

        public bool UpdateAnh(Anh obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
