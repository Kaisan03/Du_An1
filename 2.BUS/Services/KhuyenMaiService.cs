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
    public class KhuyenMaiService : IKhuyenMaiService
    {
        private IKhuyenMaiRepository _IkhuyenMaiRepository;
        public KhuyenMaiService()
        {
            _IkhuyenMaiRepository = new KhuyenMaiRepositpry();
        }
        public bool Add(KhuyenMai obj)
        {
           _IkhuyenMaiRepository.Add(obj);
            return true;
        }
        public bool DeleteD(KhuyenMai obj)
        {
            _IkhuyenMaiRepository.Delete(obj);
            return true;
        }
        public List<KhuyenMai> GetAllKhuyenMai()
        {
            return _IkhuyenMaiRepository.GetAll();
        }
        public KhuyenMai GetByid(Guid id)
        {
            throw new NotImplementedException();
        }
        public bool Update(KhuyenMai obj)
        {
            _IkhuyenMaiRepository.Update(obj);
            return true;
        }
    }
}
