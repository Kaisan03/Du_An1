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
    public class ChucVuService : IChucVuService
    {
        private IChucVuRepository _IchucVuRepository;
        public ChucVuService()
        {
            _IchucVuRepository = new ChucVuRepository();
        }
        public string Add(ViewChucVu obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }

            var cv = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };

            _IchucVuRepository.AddChucVu(cv); 
            return "Thêm thành công";
            
        }
        

        public string Delete(ViewChucVu obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var cv = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            if (_IchucVuRepository.DeleteChucVu(cv)) return "Xóa thành công";
            return "không thành công";
        }

        public List<ViewChucVu> GetAllChucVu()
        {
            List<ViewChucVu> _lstChucVu = new List<ViewChucVu>();
            _lstChucVu = (from a in _IchucVuRepository.GetAllChucVu()
                          select new ViewChucVu()
                          {
                              Id = a.Id,
                              Ma = a.Ma,
                              Ten = a.Ten,
                              TrangThai = a.TrangThai
                          }).ToList();
            return _lstChucVu;
        }

        public ChucVu GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(ViewChucVu obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var cv = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai
            };
            if (_IchucVuRepository.UpdateChucVu(cv)) return "Sửa thành công";
            return "không thành công";
        }
    }
}
