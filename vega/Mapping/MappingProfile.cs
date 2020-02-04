using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vega.Controllers.Resources;
using vega.Model;

namespace vega.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model.Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}
