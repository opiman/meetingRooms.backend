using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace meetingRooms.backend.Models
{
    public class UsersDataSource
    {
        private static List<User> usersL;
        public static List<User> getUsers()
        {
            usersL = new List<User>();
            usersL.Add(new User() { Id = 1, Surname = "Иванов", Email = "ivanov@sibedge.com", Url = "qweqwe" });
            usersL.Add(new User() { Id = 2, Surname = "Сидоров", Email = "sidorov@sibedge.com", Url = "qweqwe" });
            usersL.Add(new User() { Id = 3, Surname = "Петров", Email = "petrov@sibedge.com", Url = "qweqwe" });
            usersL.Add(new User() { Id = 4, Surname = "Самсонов", Email = "samsonov@sibedge.com", Url = "qweqwe" });
            usersL.Add(new User() { Id = 5, Surname = "Желанников", Email = "zhelannikov@sibedge.com", Url = "qweqwe" });
            return usersL;
        }
    }
}