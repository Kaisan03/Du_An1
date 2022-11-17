using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChatLieuRepository
    {
        bool AddChatLieu(ChatLieu obj);
        bool UpdateChatLieu(ChatLieu obj);
        bool DeleteChatLieu(ChatLieu obj);
        List<ChatLieu> GetAllChatLieu();
    }
}
