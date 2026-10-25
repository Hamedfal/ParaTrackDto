namespace ParaTrackDto.Models
{
    public class ManagementGroupDto
    {
        public Guid GroupId { get; set; }

        public string? GroupName { get; set; }

        public bool? IsActive { get; set; }

        public ICollection<PropertyGroupDto>? PropertyGroups { get; set; } = null;
    }
}
