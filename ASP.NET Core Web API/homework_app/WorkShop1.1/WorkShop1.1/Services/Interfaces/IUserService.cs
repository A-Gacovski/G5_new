using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1._0.Models.Data;
using WorkShop1._0.Models.Dto;

namespace WorkShop1._0.Services.Interfaces
{
    public interface IUserService
    {
        string AddUser(UserDto user);
        List<UserDto> GetAllUsers();
        UserDto GetUserById(int userId);
    }
}
