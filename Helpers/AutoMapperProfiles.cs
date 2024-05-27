using AutoMapper;
using Simple_API_Assessment.DTO_s;
using Simple_API_Assessment.Models;

namespace Simple_API_Assessment.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<Applicant, ApplicantDto>();
            CreateMap<Skill, SkillDto>();
        }
    }
}
