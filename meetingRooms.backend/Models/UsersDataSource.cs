using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace meetingRooms.backend.Models
{
    public class UsersDataSource
    {
        private static List<User> _users = null;
        public static List<User> All
        {
            get
            {
                if (_users == null)
                {
                    _users = new List<User>();
                    _users.Add(new User() { Id=1, Surname="Ivanov", Email="ivanov@sibedge.com", Url="qweqwe"});
                    _users.Add(new User() { Id = 2, Surname = "Ivanenko", Email = "sidorov@sibedge.com", Url = "qweqwe" });
                    _users.Add(new User() { Id = 3, Surname = "Ivashuk", Email = "petrov@sibedge.com", Url = "qweqwe" });
                    _users.Add(new User() { Id = 4, Surname = "Сааамсонов", Email = "ger@sibedge.com", Url = "qweqwe" });
                    _users.Add(new User() { Id = 5, Surname = "Сааааников", Email = "qweqw@sibedge.com", Url = "qweqwe" });
                    _users.Add(new User() { Id = 5, Surname = "Саников", Email = "asd@sibedge.com", Url = "qweqwe" });
                }
                return _users;
            }
        }
    }
}