using AutoMapper;
using POS.BLL.Sales.Domain;
using POS.DAL.Sales;

namespace POS.BLL.Sales.Mapping
{
    public class DatabaseToDomain : Profile
    {
        protected override void Configure()
        {
            //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<Sale, SaleModel>();
            CreateMap<SaleDetail, SaleDetailModel>();
            CreateMap<SalePayment, SalePaymentModel>();
            CreateMap<SaleReturnReceive, SaleReturnReceiveModel>();
            CreateMap<SaleReturnReceiveDetail, SaleReturnReceiveDetailModel>();
        }
    }
}
