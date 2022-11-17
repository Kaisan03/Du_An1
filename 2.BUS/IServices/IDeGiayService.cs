using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IDeGiayService
    {
        bool AddDeGiay(DeGiay obj);
        bool UpdateDeGiay(DeGiay obj);
        bool DeleteDeGiay(DeGiay obj);
        List<DeGiay> GetAllDeGiay();
    }
}
