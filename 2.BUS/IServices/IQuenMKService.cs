﻿using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQuenMKService
    {
        bool uppdateppassnv(NhanVien pass);
        List<NhanVien> GetAllNhanVien();
        string encryption(string password);
    }
}
