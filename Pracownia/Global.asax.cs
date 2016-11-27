using AutoMapper;
using Pracownia.BmwWawa;
using Pracownia.BmwWroclaw;
using Pracownia.DataObjects;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Pracownia
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CarWawa, BmwCar>()
                .ForMember(dest => dest.Series, opt => opt.MapFrom(src => src.Seria))
                .ForMember(dest => dest.Version, opt => opt.MapFrom(src => src.Wersja))
                .ForMember(dest => dest.Body, opt => opt.MapFrom(src => src.Nadwozie))
                .ForMember(dest => dest.FuelType, opt => opt.MapFrom(src => src.Silnik))
                .ForMember(dest => dest.EngineCapacity, opt => opt.MapFrom(src => src.Pojemnosc))
                .ForMember(dest => dest.Power, opt => opt.MapFrom(src => src.Moc))
                .ForMember(dest => dest.GearboxType, opt => opt.MapFrom(src => src.Skrzynia))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Cena))
                .ForMember(dest => dest.Colour, opt => opt.MapFrom(src => src.Kolor))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => "Warszawa"));

                cfg.CreateMap<Car, BmwCar>()
                // propercje o takiej samej nazwie mapowane są automatycznie
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => "Wroclaw"));
            });
        }
    }
}
