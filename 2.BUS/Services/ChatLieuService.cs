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
    public class ChatLieuService : IChatLieuService
    {
        private IChatLieuRepository _IChatLieuRepository;
        public ChatLieuService()
        {
            _IChatLieuRepository = new ChatLieuRepository();
        }
        public bool AddChatLieu(ChatLieu obj)
        {
            _IChatLieuRepository.AddChatLieu(obj);
            return true;
        }

        public bool DeleteChatLieu(ChatLieu obj)
        {
            _IChatLieuRepository.DeleteChatLieu(obj);
            return true;
        }

        public List<ChatLieu> GetAllChatLieu()
        {
            return _IChatLieuRepository.GetAllChatLieu();
        }

        public bool UpdateChatLieu(ChatLieu obj)
        {
            _IChatLieuRepository.UpdateChatLieu(obj);
            return true;
        }
    }
}
