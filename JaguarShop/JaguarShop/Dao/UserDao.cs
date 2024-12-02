using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaguarShop.Models;

namespace JaguarShop.Dao
{
    internal class UserDao
    {
        private List<User> users;
        public UserDao()
        {
            users = new List<User>();
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void UpdateUser(int id, User updateUser)
        {
            int index = users.FindIndex(user => user.Id == id);
            if (index != -1)
            {
                users[index] = updateUser;
            }
        }
    }
}
