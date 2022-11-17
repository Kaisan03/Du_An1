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
    public class MauSacService : IMauSacService
    {
        private IMauSacRepository _IMauSacRepository;
        public MauSacService()
        {
            _IMauSacRepository = new MauSacRepository();
        }
        public bool AddMauSac(MauSac obj)
        {
            _IMauSacRepository.AddMauSac(obj);
            return true;
        }

        public bool DeleteMauSac(MauSac obj)
        {
            _IMauSacRepository.DeleteMauSac(obj);
            return true;
        }

        public List<MauSac> GetAllMauSac()
        {
            return _IMauSacRepository.GetAllMauSac();
        }

        public bool UpdateMauSac(MauSac obj)
        {
            _IMauSacRepository.UpdateMauSac(obj);
            return true;
        }
    }
}
