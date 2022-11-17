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
    public class DeGiayService : IDeGiayService
    {
        private IDeGiayRepository _IDeGiayRepository;
        public DeGiayService()
        {
            _IDeGiayRepository = new DeGiayRepository();
        }
        public bool AddDeGiay(DeGiay obj)
        {
            _IDeGiayRepository.AddDeGiay(obj);
            return true;
        }

        public bool DeleteDeGiay(DeGiay obj)
        {
            _IDeGiayRepository.DeleteDeGiay(obj);
            return true;
        }

        public List<DeGiay> GetAllDeGiay()
        {
            return _IDeGiayRepository.GetAllDeGiay();
        }

        public bool UpdateDeGiay(DeGiay obj)
        {
            _IDeGiayRepository.UpdateDeGiay(obj);
            return true;
        }
    }
}
