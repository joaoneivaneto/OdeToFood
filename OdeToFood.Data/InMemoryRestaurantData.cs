using OdeToFood.Core;
using System;
using System.Linq;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData: IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=1, Name="dogao", Location="Av. Das Rosas", cuisine= CuisineType.Brasilian },
                new Restaurant{Id=2, Name="rei do espeto", Location="Praça do Forúm", cuisine= CuisineType.Brasilian },
                new Restaurant{Id=3, Name="bar do giga", Location="Cruzinha", cuisine= CuisineType.Brasilian },
                new Restaurant{Id=4, Name="bar do peixe", Location="Rodovia", cuisine= CuisineType.Idian }
            };

        }
       public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }
        public Restaurant Add(Restaurant newRestaurant)
        {
            restaurants.Add(newRestaurant);
            newRestaurant.Id = restaurants.Max(r => r.Id) + 1;
            return newRestaurant;
        }
        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurant = restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);

            if(restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Location = updatedRestaurant.Location;
                restaurant.cuisine = updatedRestaurant.cuisine;

            }
            return restaurant;
        }
        public int Commit()
        {
            return 0;
        }
        public IEnumerable<Restaurant> GetRestaurantsByName( string name = null)
        {
            return from r in restaurants 
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name select r;
        }

        public Restaurant Delete(int id)
        {
            var restaurant = restaurants.FirstOrDefault(r => r.Id == id);
            if(restaurant != null)
            {
                restaurants.Remove(restaurant);
            }
            return restaurant;
        }

        public int GetCountOfRestaurants()
        {
            return restaurants.Count();
        }
    }
}
