using FoodDeliveryApp.DomainModel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Repository.UserProfile
{
     public class UserProfileRepository : IUserProfileRepository
    {
        private DataContext _context;

        public UserProfileRepository(DataContext dataContext)
        {
            _context = dataContext;
                
        }
        public async Task<User> CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task DeleteUser(int id)
        {
            var userTodelete = await _context.Users.FindAsync(id);
            _context.Users.Remove(userTodelete);

            await _context.SaveChangesAsync();
        }

        public async Task<User> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async  Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task UpdateUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
