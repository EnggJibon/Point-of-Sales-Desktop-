using AutoMapper;
using POS.BLL.HRM.Domain;
using POS.DAL.HRM;

namespace POS.BLL.HRM.Mapping
{
    public class DomainToDatabase:Profile
    {
        protected override void Configure()
        {
            //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<DepartmentModel, Department>();
            CreateMap<DesignationModel, Designation>();
        }
    }
}
