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
    public class AnhService : IAnhService
    {
        private IAnhRepository _IAnhRepository;
        public AnhService()
        {
            _IAnhRepository = new AnhRepository();
        }
        public bool AddAnh(Anh obj)
        {
            _IAnhRepository.AddAnh(obj);
            return true;
        }

        public bool DeleteAnh(Anh obj)
        {
            _IAnhRepository.DeleteAnh(obj);
            return true;
        }

        public List<Anh> GetAllAnh()
        {
            return _IAnhRepository.GetAllAnh();
        }

        public bool UpdateAnh(Anh obj)
        {
            _IAnhRepository.UpdateAnh(obj);
            return true;
        }
    }
}
