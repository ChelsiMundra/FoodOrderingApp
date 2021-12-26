using FoodDeliveryApp.DomainModel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Repository.DishRepository
{
    public class DishRepository : IDishRepository
    {
        private readonly DataContext _context;

        public DishRepository(DataContext context)
        {
            _context = context;
        }

        public Dish AddDish(Dish dish)
        {
            dish.CreatedAt = DateTime.Now;
            _context.Dishes.Add(dish);
            _context.SaveChanges();
            return dish;
        }

        public void EditDish(Dish dish)
        {
            _context.Dishes.Update(dish);
            _context.SaveChanges();
        }

        public void DeleteDish(Dish dish)
        {
            dish.IsDeleted = true;
            dish.DeletedAt = DateTime.Now;
            _context.Dishes.Update(dish);
            _context.SaveChanges();
        }


        public List<Dish> GetDishes()
        {
            return _context.Dishes.AsNoTracking().ToList();
        }

        public Dish GetDish(int id)
        {
            return _context.Dishes.AsNoTracking().SingleOrDefault(x => x.Id == id);
        }
    }
}
