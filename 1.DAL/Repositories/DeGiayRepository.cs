using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class DeGiayRepository : IDeGiayRepository
    {
        private FpolyDBContext _dbContext;
        public DeGiayRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool AddDeGiay(DeGiay obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteDeGiay(DeGiay obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<DeGiay> GetAllDeGiay()
        {
            return _dbContext.DeGiays.ToList();
        }

        public bool UpdateDeGiay(DeGiay obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
