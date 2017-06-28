using AutoMapper;
using Vega.Entities;
using Vega.Models;

namespace Vega.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeDto>();
            CreateMap<Feature, FeatureDto>();
        }
    }
}