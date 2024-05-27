using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Simple_API_Assessment.Data.Repository;
using Simple_API_Assessment.DTO_s;
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
        private readonly IMapper _mapper;
        
        public ApplicantController(IApplicantRepository applicantRepository, IMapper mapper)
        {
            _applicantRepository = applicantRepository;  
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicantDto>>> GetAllApplicants()
        {

            var applicants = await _applicantRepository.GetAllApplicantsAsync();

            if (applicants.Count() < 1) return NoContent();

            return Ok(applicants);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicantDto>> GetApplicantById(int id)
        {

            var applicant  = await _applicantRepository.GetApplicantByIdAsync(id);

            if (applicant == null)
            {
                return NotFound();
            }

            return Ok(applicant);

        }
    }
}
