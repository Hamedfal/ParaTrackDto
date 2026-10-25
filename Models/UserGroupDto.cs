namespace ParaTrackDto.Models
{
    public class UserGroupDto
    {
        public Guid RowId { get; set; }

        public Guid UserId { get; set; }

        public Guid GroupId { get; set; }

        public Guid RoleId { get; set; }

        public UserDto? User { get; set; } = null;

        public ManagementGroupDto? ManagementGroup { get; set; } = null;

        public AccessRoleDto? AccessRole { get; set; } = null;
    }
}
