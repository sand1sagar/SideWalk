using AutoMapper;
using Sidewalk.Logic.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SidewalkUI.Common
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            ConfigureMapping();
        }
        private static void ConfigureMapping()
        {
            AutoMapper.Mapper.Initialize(cfg => {
                cfg.CreateMap<getAffidavitByParameter_Result, sw_posting>()
                .ForMember(dest => dest.date_added, opt => opt.MapFrom(src => (src.date_added != null) ? src.date_added.Value.ToShortDateString() : string.Empty))
                .ForMember(dest => dest.post_dt, opt => opt.MapFrom(src => (src.post_dt != null) ? src.post_dt.Value.ToShortDateString() : string.Empty));

                cfg.CreateMap<Affidavit, Models.NoticeLetterViewModel>()
               .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => (src.CreateDate != null) ? src.CreateDate.Value.ToShortDateString() : string.Empty))
               .ForMember(dest => dest.InspectionDate, opt => opt.MapFrom(src => (src.InspectionDate != null) ? src.InspectionDate.Value.ToShortDateString() : string.Empty));

                cfg.CreateMap<Affidavit, Models.AffidavitViewModel>()
               .ForMember(dest => dest.date_added, opt => opt.MapFrom(src => (src.CreateDate != null) ? src.CreateDate.Value.ToShortDateString() : string.Empty))
               .ForMember(dest=>dest.PropertyDescription,opt=>opt.MapFrom(src=>src.SiteStreetNumber+" "+src.SiteDistrict+" "+src.SiteStreetName+" "+src.SiteStreetDesignator))
               .ForMember(dest => dest.post_dt, opt => opt.MapFrom(src => (src.InspectionDate != null) ? src.InspectionDate.Value.ToShortDateString() : string.Empty));
            });
        }
    }
}