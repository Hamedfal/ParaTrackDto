namespace ParaTrackDto.Models
{
    public class ManagementCompanyDto
    {
        public Guid CompanyId { get; set; }

        public string? CompanyName { get; set; }

        public string? ContactName { get; set; }

        public string? ContactEmail { get; set; }

        public string? ContactPhone { get; set; }

        public bool? IsActive { get; set; }

        public ICollection<PropertyDto>? Properties { get; set; } = null;
    }
}
