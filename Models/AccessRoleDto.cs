using ParaTrackDto.Types;

namespace ParaTrackDto.Models
{
    public class AccessRoleDto
    {
        public Guid RoleId { get; set; }

        public string? RoleName { get; set; }

        public ParaPermissions RoleAccess { get; set; } = 0;
    }
}
