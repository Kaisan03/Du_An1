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
    public class GioHangChiTietService : IGioHangChiTietService
    {
        private IGioHangChiTietRepository _IGioHangCTRepos;
        private IChiTietGiayRepository _IChiTietSPRepos;
        private IGioHangRepository _IGioHangRepos;
        private List<ViewGioHangChiTiet> _lstViewGioHangCT;
        public GioHangChiTietService()
        {
            _IGioHangCTRepos = new GioHangChiTietRepository();
            _IChiTietSPRepos = new ChiTietGiayRepository();
            _IGioHangRepos = new GioHangRepository();
        }
        public bool AddGioHangCT(GioHangChiTiet obj)
        {
            _IGioHangCTRepos.AddGioHangCT(obj);
            return true;
        }

        public bool DeleteGioHangCT(GioHangChiTiet obj)
        {
            _IGioHangCTRepos.DeleteGioHangCT(obj);
            return true;
        }

        public List<GioHangChiTiet> GetAllGioHangCT()
        {
            return _IGioHangCTRepos.GetAllGioHangCT();
        }

        //public List<GioHangView> GetViewGioHangCT()
        //{
        //    re
        //}

        public bool UpdateGioHangCT(GioHangChiTiet obj)
        {
            _IGioHangCTRepos.UpdateGioHangCT(obj);
            return true;
        }
    }
}
