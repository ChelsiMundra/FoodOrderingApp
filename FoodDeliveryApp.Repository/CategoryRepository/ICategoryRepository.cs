using FoodDeliveryApp.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Repository.CategoryRepository
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
        Category GetCategory(int id);

        Category AddCategory(Category category);
        void DeleteCategory(Category category);
        void EditCategory(Category category);

    }
}
