using Simple_API_Assessment.DTO_s;
using Simple_API_Assessment.Models;

namespace Simple_API_Assessment.Data.Repository
{
    public interface IApplicantRepository
    {
        Task<IEnumerable<ApplicantDto>> GetAllApplicantsAsync();
        Task<ApplicantDto> GetApplicantByIdAsync(int id);
    }
}
