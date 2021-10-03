using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1._0.Models.Data;

namespace WorkShop1._0
{
    public class CashDb
    {
        public static int UserIdCounter = 1;
        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                UserName = "aGacovski",
                Password = "123456",
                FirstName = "Aleksandar",
                LastName = "Gacovski",
                FavouriteGenre = Models.Enums.Genre.SciFi,
                Subscription = Models.Enums.Subscription.Default
            }
        };

        public static int MovieIdCounter = 2;
        public static List<Movie> Movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "Ocean's Eleven",
                Description = "Nice Movie",
                Genre = Models.Enums.Genre.Action,
                NewDate = DateTime.Now,
                UserId = Users.First().Id

            },
            new Movie
            {
                Id = 2,
                Title = "The King",
                Description = "Good to watch",
                Genre = Models.Enums.Genre.SciFi,
                NewDate = DateTime.Now,
                UserId = Users.First().Id
            }
        };
    }
}
