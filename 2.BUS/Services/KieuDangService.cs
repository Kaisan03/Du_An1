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
    public class KieuDangService : IKieuDangService
    {
        private IKieuDangRepository _IKieuDangRepository;
        public KieuDangService()
        {
            _IKieuDangRepository = new KieuDangRepository();
        }
        public bool AddKieuDang(KieuDang obj)
        {
            _IKieuDangRepository.AddKieuDang(obj);
            return true;
        }

        public bool DeleteKieuDang(KieuDang obj)
        {
            _IKieuDangRepository.DeleteKieuDang(obj);
            return true;
        }

        public List<KieuDang> GetAllKieuDang()
        {
            return _IKieuDangRepository.GetAllKieuDang();
        }

        public bool UpdateKieuDang(KieuDang obj)
        {
            _IKieuDangRepository.UpdateKieuDang(obj);
            return true;
        }
    }
}
