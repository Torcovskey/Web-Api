using System;
using System.Collections.Generic;
using Data.Entity;
using Service.ApiEntity;

namespace Service.Converter
{
    public class ProductsConverter : IConverter<Product, ApiProduct>
    {
        public IEnumerable<ApiProduct> Convert(IEnumerable<Product> entities)
        {
            List<ApiProduct> apiProducts = new List<ApiProduct>();
            foreach (var entity in entities)
            {
                apiProducts.Add(ConvertOne(entity));
            }
            return apiProducts;
        }

        public ApiProduct ConvertOne(Product entity)
        {
            return new ApiProduct()
            {
                Id = entity.Id,
                Category = entity.Category.Name,
                Company = entity.Company.Name,
                Model = entity.Model,
                NumberOfProducts = entity.NumberOfProducts,
                Price = entity.Price
            };
        }
    }
}
