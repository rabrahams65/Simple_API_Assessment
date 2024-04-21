using Microsoft.EntityFrameworkCore;
using Simple_API_Assessment.Models;

namespace Simple_API_Assessment.Data.Repository
{
    public class ApplicantRepo : IApplicantRepository
    {
        private readonly DataContext _context;
        public ApplicantRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<Applicant> GetApplicantByIdAsync(int id)
        {

            return await _context.Applicant.Include(s => s.Skills).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Applicant>> GetAllApplicantsAsync()
        {
            return await _context.Applicant.Include(s => s.Skills).ToListAsync();
        }
    }
}
