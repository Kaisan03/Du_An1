using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class GiaoCaService : IGiaoCaService
    {
        private IGiaoCaRepository _IGiaoCaRypository;
        public GiaoCaService()
        {
            _IGiaoCaRypository = new GiaoCaRepositpotory();
        }
        public bool Add(GiaoCa obj)
        {
            _IGiaoCaRypository.Add(obj);
            return true;
        }

        public bool Delete(GiaoCa obj)
        {
            _IGiaoCaRypository.Delete(obj);
            return true;
        }

        public List<GiaoCa> GetAllGiaoca()
        {
            return _IGiaoCaRypository.GetAll();
        }

        public bool Update(GiaoCa obj)
        {
            _IGiaoCaRypository.Update(obj);
            return true;
        }
    }
}
