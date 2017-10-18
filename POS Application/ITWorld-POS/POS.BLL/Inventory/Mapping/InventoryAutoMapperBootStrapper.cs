using AutoMapper;

namespace POS.BLL.Inventory.Mapping
{
    public class InventoryAutoMapperBootStrapper : Profile
    {
        public static void Initialize()
        {
            Mapper.AddProfile(new DomainToDatabase());
            Mapper.AddProfile(new DatabaseToDomain());
        }
    }
}
