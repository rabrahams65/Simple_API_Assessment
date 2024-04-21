using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Simple_API_Assessment.Data.Repository;
using Simple_API_Assessment.Models;

namespace Simple_API_Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [ProducesResponseType(500)]
    public class ApplicantController : ControllerBase
    {
        private readonly IApplicantRepository _applicantRepository;
        
        public ApplicantController(IApplicantRepository applicantRepository)
        {
            _applicantRepository = applicantRepository;  
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Applicant>>> GetAllApplicants()
        {
            try
            {
                var applicants = await _applicantRepository.GetAllApplicantsAsync();

                if (applicants.Count() < 1) return NoContent();

                return Ok(applicants);
            }
            catch (Exception ex)
            {
                 return BadRequest(ex.Message);
            }
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Applicant>> GetApplicantById(int id)
        {
            try
            {
                Applicant user  = await _applicantRepository.GetApplicantByIdAsync(id);

                if (user == null)
                {
                    return NotFound();
                }

                return Ok(user);


            }
            catch (Exception ex)
            {
                return BadRequest( ex.Message);
            }

        }
    }
}
