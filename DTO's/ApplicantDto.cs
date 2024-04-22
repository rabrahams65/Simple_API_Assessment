

namespace Simple_API_Assessment.DTO_s
{
    public class ApplicantDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<SkillDto>? Skills { get; set; }
    }
}
