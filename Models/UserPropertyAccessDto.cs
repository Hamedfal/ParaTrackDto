using ParaTrackDto.Types;

namespace ParaTrackDto.Models
{
    public class UserPropertyAccessDto
    {
        public Guid RowId { get; set; }

        public Guid UserId { get; set; }

        public Guid PropertyId { get; set; }

        public ParaPermissions Access { get; set; } = ParaPermissions.NONE;

        public UserDto? User { get; set; } = null;

        public PropertyDto? Property { get; set; } = null;
    }
}
