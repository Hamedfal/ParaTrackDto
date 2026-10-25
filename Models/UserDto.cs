using ParaTrackDto.Types;

namespace ParaTrackDto.Models
{
    public class UserDto
    {
        public Guid UserId { get; set; }

        public string? Email { get; set; }

        public string? DisplayName { get; set; }

        public string? Title { get; set; }

        public ParaRole ParaRole { get; set; } = 0;

        public bool? IsActive { get; set; }

        public ICollection<UserGroupDto>? UserGroups { get; set; } = null;
    }
}
