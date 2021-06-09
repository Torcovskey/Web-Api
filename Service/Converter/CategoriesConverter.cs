using System.Collections.Generic;
using Data.Entity;
using Service.ApiEntity;

namespace Service.Converter
{
    public class CategoriesConverter : IConverter<Category, ApiCategory>
    {
        public IEnumerable<ApiCategory> Convert(IEnumerable<Category> entities)
        {
            List<ApiCategory> apiCategories = new List<ApiCategory>();
            foreach (var entity in entities)
            {
                apiCategories.Add(ConvertOne(entity));
            }
            return apiCategories;
        }

        public ApiCategory ConvertOne(Category entity)
        {
            return new ApiCategory()
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}
