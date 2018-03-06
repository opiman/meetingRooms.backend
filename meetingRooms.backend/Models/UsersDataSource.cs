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
                    _users.Add(new User() { Id=1, Surname="ivanov", Email="ivanov@sibedge.com", Url="qweqwe"});
                    _users.Add(new User() { Id = 2, Surname = "ivanenko", Email = "sidorov@sibedge.com", Url = "qweqwe" });
                    _users.Add(new User() { Id = 3, Surname = "ivashuk", Email = "petrov@sibedge.com", Url = "qweqwe" });
                    _users.Add(new User() { Id = 4, Surname = "сааамсонов", Email = "ger@sibedge.com", Url = "qweqwe" });
                    _users.Add(new User() { Id = 5, Surname = "сааааников", Email = "qweqw@sibedge.com", Url = "qweqwe" });
                    _users.Add(new User() { Id = 5, Surname = "саников", Email = "asd@sibedge.com", Url = "qweqwe" });
                }
                return _users;
            }
        }
    }
}