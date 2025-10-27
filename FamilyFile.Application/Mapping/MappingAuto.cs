using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Application.Mapping
{
    public static class MappingAuto<T1, T2>
    {
        public static T2 Map(T1 source)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<T1, T2>());
            var mapper = new Mapper(config);
            return mapper.Map<T2>(source);
        }

        public static List<T2> MapLst(List<T1> source)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<T1, T2>());
            var mapper = new Mapper(config);
            return mapper.Map<List<T2>>(source);
        }

    }
}
