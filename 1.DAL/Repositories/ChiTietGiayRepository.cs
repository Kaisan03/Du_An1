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
    public class ChiTietGiayRepository : IChiTietGiayRepository
    {
        private FpolyDBContext _dbContext;
        public ChiTietGiayRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool AddChiTietGiay(ChiTietGiay obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteChiTietGiay(ChiTietGiay obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChiTietGiay> GetAllChiTietGiay()
        {
            return _dbContext.ChiTietGiays.ToList();
        }

        public bool UpdateChiTietGiay(ChiTietGiay obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
