using AutoMapper;

namespace POS.BLL.HRM.Mapping
{
    public class HRMAutoMapperBootStrapper : Profile
    {
        public static void Initialize()
        {
            Mapper.AddProfile(new DomainToDatabase());
            Mapper.AddProfile(new DatabaseToDomain());
        }
    }
}
