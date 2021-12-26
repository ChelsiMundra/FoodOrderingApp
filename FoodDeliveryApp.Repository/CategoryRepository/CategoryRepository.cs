using FoodDeliveryApp.DomainModel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Repository.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public Category AddCategory(Category category)
        {
            category.CreatedAt = DateTime.Now;
            category.MenuId = 1;
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public void EditCategory(Category category)
        {
            category.MenuId = 1;
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            category.IsDeleted = true;
            category.MenuId = 1;
            category.DeletedAt = DateTime.Now;
            _context.Categories.Update(category);
            _context.SaveChanges();
        }


        public List<Category> GetCategories()
        {
            return _context.Categories.AsNoTracking().ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.AsNoTracking().SingleOrDefault(x => x.Id == id);
        }
    }
}
