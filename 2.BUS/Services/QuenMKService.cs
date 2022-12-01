using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace _2.BUS.Services
{
    public class QuenMKService : IQuenMKService
    {
        private INhanVienRepository _iServicesNhanVien;
        private List<NhanVien> _lstNhanVien;
        public QuenMKService()
        {
            _iServicesNhanVien = new NhanVienRepository();
            _lstNhanVien = new List<NhanVien>();
            getlstnhanvienfromDB();
        }
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        public List<NhanVien> GetAllNhanVien()
        {
            throw new NotImplementedException();
        }

        public List<NhanVien> getlstnhanvienfromDB()
        {
            _lstNhanVien = _iServicesNhanVien.GetAllNhanVien();
            return _lstNhanVien;
        }

        public bool uppdateppassnv(NhanVien pass)
        {
            _iServicesNhanVien.Update(pass);
            return true;
        }
    }
}
