using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class KhachHangService : IKhachHangService
    {
        private IKhachHangRepository _ikhachHangRepository;
        public KhachHangService()
        {
            _ikhachHangRepository = new KhachHangRepository();
        }
      

        public bool Add(KhachHang obj)
        {
           _ikhachHangRepository.Add(obj);
            return true;
        }

        

        public bool Delete(KhachHang obj)
        {
           _ikhachHangRepository.Delete(obj);
            return true;

        }

      

        public bool Update(KhachHang obj)
        {
           _ikhachHangRepository.Update(obj);
            return true;
        }

        

        public List<KhachHang> GetAll()
        {
          return _ikhachHangRepository.GetAll();
        }
    }
}
