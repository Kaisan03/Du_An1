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
    public class GiaoCaRepositpotory : IGiaoCaRepository
    {
        private FpolyDBContext _dbContext;
        public GiaoCaRepositpotory()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(GiaoCa obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(GiaoCa obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<GiaoCa> GetAll()
        {
            return _dbContext.GiaoCas.ToList();
        }

        public bool Update(GiaoCa obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
