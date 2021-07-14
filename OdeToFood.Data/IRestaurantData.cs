using OdeToFood.Core;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
    }
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
        public IEnumerable<Restaurant> GetRestaurantsByName( string name = null)
        {
            return from r in restaurants 
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name select r;
        }
    }
}
