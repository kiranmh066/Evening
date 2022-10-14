using BookShowDAL.Repost;
using BookShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShowBLL.Services
{
    public class UserService
    {
        IUserRepository _userRepository;


        //Unable to resolve ====>>>> Object issues
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        //Add User
        public void AddUser(User user)
        {
            _userRepository.AddUser(user);
        }
        //Update User
        public void UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
        }

        //Delete User
        public void DeleteUser(int userId)
        {
            _userRepository.DeleteUser(userId);
        }

        //Get UserByID
        public User GetUserById(int userId)
        {
            return _userRepository.GetUserById(userId);
        }

        //Get Users
        public IEnumerable<User> GetUser()
        {
            return _userRepository.GetUsers();
        }
    }
}