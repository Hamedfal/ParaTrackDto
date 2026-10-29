namespace ParaTrackDto.Models
{
    public class PropertyDto
    {
        public Guid PropertyId { get; set; }

        public Guid? CompanyId { get; set; }

        public string? PropertyName { get; set; }

        public string? Address { get; set; }

        public int? PrismSiteId { get; set; }

        public bool? IsActive { get; set; }

        public ManagementCompanyDto? ManagementCompany { get; set; } = null;

        public ICollection<TourDto>? Tours { get; set; } = null;

        public ICollection<CheckpointDto>? Checkpoints { get; set; } = null;
    }
}
