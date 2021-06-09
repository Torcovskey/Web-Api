using Data.ApiEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using Data.Entity;


namespace MyShop.ConvertToApi
{
    public static class ConvertToApi
    {
        public static IEnumerable<ApiCategory> Categories(IQueryable<Category> categories)
        {
            List<ApiCategory> returnList = new List<ApiCategory>();
            foreach (var category in categories)
            {
                returnList.Add(new ApiCategory()
                {
                    Id = category.Id,
                    Name = category.Name
                });
            }
            return returnList;
        }

        public static ApiProduct Product(Product product)
        {
            return new ApiProduct()
            {
                Id = product.Id,
                Company = product.Company.Name,
                Category = product.Category.Name,
                Model = product.Model,
                NumberOfProducts = product.NumberOfProducts,
                Price = product.Price
            };
        }
    }
}
