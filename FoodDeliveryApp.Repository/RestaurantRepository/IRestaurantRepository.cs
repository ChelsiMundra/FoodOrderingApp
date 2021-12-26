using FoodDeliveryApp.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Repository.RestaurantRepository
{
    public interface IRestaurantRepository
    {
        List<Restaurant> GetRestaurants();
        Restaurant GetRestaurant(int id);

        Restaurant AddRestaurant(Restaurant res);
        void DeleteRestaurant(Restaurant res);
        void EditRestaurant(Restaurant res);
       
    }
}
