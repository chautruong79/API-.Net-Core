using AssignmentList.Dtos;
using AssignmentList.Models;
using AutoMapper;

namespace AssignmentList.Profiles
{
    public class AssignmentProfiles : Profile
    {
        public AssignmentProfiles()
        {
            //Map AssignmentItem to AssignmentDto        
            CreateMap<AssignmentItem, AssignmentDto>();
            //Map AssignmentCreateDto to AssignmentItem        
            CreateMap<AssignmentCreateDto, AssignmentItem>();
            CreateMap<AssignmentUpdateDto, AssignmentItem>();
            CreateMap<AssignmentItem, AssignmentUpdateDto>();
        }
    }
}