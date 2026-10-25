using System.ComponentModel.DataAnnotations;

namespace ParaTrackDto.Models
{
    public class IncidentActionDto
    {
        public Guid ActionId { get; set; }

        public Guid? IncidentId { get; set; }

        public Guid? ByUserId { get; set; }

        public DateTimeOffset? ActionAt { get; set; }

        public string? Comments { get; set; }

        public string? MediaUrl { get; set; }

        [MaxLength(100)]
        public string? MediaType { get; set; }

        public bool SoftDelete { get; set; }

        public IncidentDto? Incident { get; set; } = null;

        public UserDto? ByUser { get; set; } = null;
    }
}
