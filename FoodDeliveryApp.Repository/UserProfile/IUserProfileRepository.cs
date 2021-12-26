using FoodDeliveryApp.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Repository.UserProfile
{
    public interface IUserProfileRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);

        Task<User> CreateUser(User user);

        Task UpdateUser(User user);

        Task DeleteUser(int id);

    }
}
