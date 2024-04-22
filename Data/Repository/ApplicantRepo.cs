using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Simple_API_Assessment.DTO_s;
using Simple_API_Assessment.Models;

namespace Simple_API_Assessment.Data.Repository
{
    public class ApplicantRepo : IApplicantRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ApplicantRepo(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApplicantDto> GetApplicantByIdAsync(int id)
        {

            return await _context.Applicant
                .Where(a => a.Id == id)
                .ProjectTo<ApplicantDto>(_mapper.ConfigurationProvider)
                .SingleAsync();
        }

        public async Task<IEnumerable<ApplicantDto>> GetAllApplicantsAsync()
        {
            return await _context.Applicant
                .ProjectTo<ApplicantDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
