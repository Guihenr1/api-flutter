using AutoMapper;

namespace Api.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {

            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DomainToDTOMappingProfile>();
                cfg.AddProfile<DTOMappingProfileToDomain>();
            });
        }
    }
}