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
    public class SanPhamService : ISanPhamService
    {
        private ISanPhamRepository _ISanPhamRepository;
        public SanPhamService()
        {
            _ISanPhamRepository = new SanPhamRepository();
        }
        public bool AddSanPham(SanPham obj)
        {
            _ISanPhamRepository.AddSanPham(obj);
            return true;
        }

        public bool DeleteSanPham(SanPham obj)
        {
            _ISanPhamRepository.DeleteSanPham(obj);
            return true;
        }

        public List<SanPham> GetAllSanPham()
        {
            return _ISanPhamRepository.GetAllSanPham();
        }

        public bool UpdateSanPham(SanPham obj)
        {
            _ISanPhamRepository.UpdateSanPham(obj);
            return true;
        }
    }
}
