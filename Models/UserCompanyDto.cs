namespace ParaTrackDto.Models
{
    public class UserCompanyDto
    {
        public Guid RowId { get; set; }

        public Guid UserId { get; set; }

        public Guid? CompanyId { get; set; }

        public bool? AllPropertyAccess { get; set; }

        public UserDto? User { get; set; } = null;

        public ManagementCompanyDto? ManagementCompany { get; set; } = null;
    }
}
