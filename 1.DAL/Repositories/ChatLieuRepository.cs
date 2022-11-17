using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ChatLieuRepository : IChatLieuRepository
    {
        private FpolyDBContext _dbContext;
        
        public ChatLieuRepository()
        {
            
            _dbContext = new FpolyDBContext();
            
        }
        public bool AddChatLieu(ChatLieu obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteChatLieu(ChatLieu obj)
        {   
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChatLieu> GetAllChatLieu()
        {
            return _dbContext.ChatLieus.ToList();
        }

        public bool UpdateChatLieu(ChatLieu obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
