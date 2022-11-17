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
    public class MauSacRepository : IMauSacRepository
    {
        private FpolyDBContext _dbContext;
        public MauSacRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool AddMauSac(MauSac obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteMauSac(MauSac obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<MauSac> GetAllMauSac()
        {
            return _dbContext.MauSacs.ToList();
        }

        public bool UpdateMauSac(MauSac obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
