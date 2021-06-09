using System.Collections.Generic;
using Data.Entity;
using Service.ApiEntity;

namespace Service.Converter
{
    public class CompaniesConverter : IConverter<Company, ApiCompany>
    {
        public IEnumerable<ApiCompany> Convert(IEnumerable<Company> entities)
        {
            List<ApiCompany> apiCompanies = new List<ApiCompany>();
            foreach(var entity in entities)
            {
                apiCompanies.Add(ConvertOne(entity));
            }
            return apiCompanies;
        }

        public ApiCompany ConvertOne(Company entity)
        {
            return new ApiCompany()
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}
