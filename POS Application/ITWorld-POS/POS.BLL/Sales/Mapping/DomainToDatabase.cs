using AutoMapper;
using POS.BLL.Sales.Domain;
using POS.DAL.Sales;

namespace POS.BLL.Sales.Mapping
{
    public class DomainToDatabase : Profile
    {
        protected override void Configure()
        {
            //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<SaleModel, Sale>();
            CreateMap<SaleDetailModel, SaleDetail>();
            CreateMap<SalePaymentModel, SalePayment>();
            CreateMap<SaleReturnReceiveModel, SaleReturnReceive>();
            CreateMap<SaleReturnReceiveDetailModel, SaleReturnReceiveDetail>();
        }
    }
}
