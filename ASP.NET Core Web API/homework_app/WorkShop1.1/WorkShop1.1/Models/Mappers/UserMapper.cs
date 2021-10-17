using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1._0.Models.Data;
using WorkShop1._0.Models.Dto;

namespace WorkShop1._0.Models.Mappers
{
    public class UserMapper
    {
        public static UserDto UserModelToUserDto(User user)
        {
            return new UserDto
            {
                Id = user.Id,
                UserName = user.UserName,
                Password = user.Password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                FavouriteGenre = user.FavouriteGenre,
                Subscription = user.Subscription,
            };
        }

        public static User UserDtoToUserModel(UserDto user)
        {
            return new User
            {
                Id = user.Id,
                UserName = user.UserName,
                Password = user.Password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                FavouriteGenre = user.FavouriteGenre,
                Subscription = user.Subscription
            };
        }
    }
}
