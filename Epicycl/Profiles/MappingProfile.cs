using AutoMapper;

using Epicycl.DTOs;
using Epicycl.Models;
namespace Epicycl.Properties
{ 

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<Satellite, SatelliteDto>();
            CreateMap<SatelliteDto, Satellite>();
        }
    }
}
