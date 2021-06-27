using AutoMapper;
using PCBack.Application.Features.Tasks;
using PCBack.Domain.Entities;

namespace PCBack.Application.Mappings
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<TaskEntity, CompetitionTask>()
                .ReverseMap();
        }
    }
}
