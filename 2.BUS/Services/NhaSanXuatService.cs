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
    public class NhaSanXuatService : INhaSanXuatService
    {
        private INhaSanXuatRepository _INSXRepository;
        public NhaSanXuatService()
        {
            _INSXRepository = new NhaSanXuatRepository();
        }
        public bool AddNSX(Nsx obj)
        {
            _INSXRepository.AddNSX(obj);
            return true;
        }

        public bool DeleteNSX(Nsx obj)
        {
            _INSXRepository.DeleteNSX(obj);
            return true;
        }

        public List<Nsx> GetAllNSX()
        {
            return _INSXRepository.GetAllNSX();
        }

        public bool UpdateNSX(Nsx obj)
        {
            _INSXRepository.UpdateNSX(obj);
            return true;
        }
    }
}
