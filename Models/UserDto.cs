using ParaTrackDto.Types;

namespace ParaTrackDto.Models
{
    public class UserDto
    {
        public Guid UserId { get; set; }

        public string? Email { get; set; }

        public string? DisplayName { get; set; }

        public string? Title { get; set; }

        public string? Mobile { get; set; }

        public ParaLevel ParaLevel { get; set; } = 0;

        public bool? IsActive { get; set; }

        public ICollection<UserCompanyDto>? UserCompanies { get; set; } = null;
    }
}
