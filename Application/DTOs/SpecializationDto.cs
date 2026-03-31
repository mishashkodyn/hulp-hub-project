using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class SpecializationDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public class SpecializationAdminDto : SpecializationDto
    {
        public int PsychologistsCount { get; set; }
        public int ApplicationsCount { get; set; }
    }

    public class CreateUpdateSpecializationDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
