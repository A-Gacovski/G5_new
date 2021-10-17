using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1._0.Models.Data;
using WorkShop1._0.Models.Dto;
using WorkShop1._0.Models.Mappers;
using WorkShop1._0.Repositories.IRepository;
using WorkShop1._0.Services.Interfaces;

namespace WorkShop1._0.Services.Classses
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService (IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public string AddUser(UserDto user)
        {

            if (string.IsNullOrEmpty(user.UserName))
            {
                throw new Exception("UserName is empty");
            }
            if (string.IsNullOrEmpty(user.Password))
            {
                throw new Exception("Password is empty");
            }
            if (string.IsNullOrEmpty(user.FirstName))
            {
                throw new Exception("First Name is Empty");
            }
            if (string.IsNullOrEmpty(user.LastName))
            {
                throw new Exception("Last Name is Empty");
            }

            var userModel = UserMapper.UserDtoToUserModel(user);
            _userRepository.Add(userModel);

            return "A new user is Added";
        }

        public List<UserDto> GetAllUsers()
        {
            return _userRepository.GetAll().Select(user => UserMapper.UserModelToUserDto(user)).ToList();
                
        }

        public UserDto GetUserById(int userId)
        {
            var oneUser = _userRepository.GetAll().FirstOrDefault(u => u.Id == userId);
            if (oneUser == null)
            {
                throw new Exception("User is not found");
            }
            return UserMapper.UserModelToUserDto(oneUser);
        }
    }
}
