namespace ParaTrackDto.Models
{
    public class UserPropertyDto
    {
        public Guid RowId { get; set; }

        public Guid? UserId { get; set; }

        public Guid? PropertyId { get; set; }

        public Guid? RoleId { get; set; }

        public UserDto? User { get; set; } = null;

        public PropertyDto? Property { get; set; } = null;

        public AccessRoleDto? Role { get; set; } = null;
    }
}
