using AutoMapper;

namespace POS.BLL.Sales.Mapping
{
    public class SalesAutoMapperBootStrapper : Profile
    {
        public static void Initialize()
        {
            Mapper.AddProfile(new Inventory.Mapping.DomainToDatabase());
            Mapper.AddProfile(new Inventory.Mapping.DatabaseToDomain());
        }
    }
}
