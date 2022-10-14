using BookShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShowDAL.Repost
{
    public interface IUserRepository
    {
        void AddUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int userId);

        User GetUserById(int userId);

        IEnumerable<User> GetUsers();
    }
}
