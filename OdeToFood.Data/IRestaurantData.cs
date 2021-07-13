using OdeToFood.Core;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryRestaurantData: IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=1, Name="dogao", Location="Av. Das Rosas", cuisine= CuisineType.Brasilian }
            };

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants orderby r.Name select r;
        }
    }
}
