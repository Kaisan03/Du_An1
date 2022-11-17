using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ChiTietKhuyenMaiReposity : IChiTietKhuyenMaiRepository
    {
        public FpolyDBContext _dbConText;
        public ChiTietKhuyenMaiReposity()
        {
            _dbConText = new FpolyDBContext();
        }
        public bool Add(ChiTietKhuyenMai obj)
        {
           if(obj == null) return false;
            _dbConText.ChiTietKhuyenMais.Add(obj);
            _dbConText.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietKhuyenMai obj)
        {
            if (obj == null) return false;
            var temp = _dbConText.ChiTietKhuyenMais.FirstOrDefault(c => c.Id == obj.Id);
            _dbConText.ChiTietKhuyenMais.Remove(temp);
            _dbConText.SaveChanges();
            return true;
        }

        public List<ChiTietKhuyenMai> GetAll()
        {
            return _dbConText.ChiTietKhuyenMais.ToList();
        }

        public ChiTietKhuyenMai GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ChiTietKhuyenMai obj)
        {
            if (obj == null) return false;
            var temp = _dbConText.ChiTietKhuyenMais.FirstOrDefault(c => c.Id == obj.Id);
            temp.IdKhuyenMai = obj.IdKhuyenMai;
            temp.IdChiTietGiay = obj.IdChiTietGiay;
            temp.TrangThai = obj.TrangThai;
            _dbConText.ChiTietKhuyenMais.Update(temp);
            _dbConText.SaveChanges();
            return true;
        }
    }
}
