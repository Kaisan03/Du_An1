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
    public class SizeService : ISizeService
    {
        private ISizeRepository _ISizeRepository;
        public SizeService()
        {
            _ISizeRepository = new SizeRepository();
        }
        public bool AddSize(Size obj)
        {
            _ISizeRepository.AddSize(obj);
            return true;
        }

        public bool DeleteSize(Size obj)
        {
            _ISizeRepository.DeleteSize(obj);
            return true;
        }

        public List<Size> GetAllSize()
        {
            return _ISizeRepository.GetAllSize();
        }

        public bool UpdateSize(Size obj)
        {
            _ISizeRepository.UpdateSize(obj);
            return true;
        }
    }
}
