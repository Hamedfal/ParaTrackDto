using ParaTrackDto.Types;

namespace ParaTrackDto.Models
{
    public class IncidentDto
    {
        public Guid IncidentId { get; set; }

        public Guid? PropertyId { get; set; }

        public Guid? CheckpointId { get; set; }

        public Guid IncidentTypeId { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public string? LocationNotes { get; set; }

        public string? IncidentNotes { get; set; }

        public IncidentPriority? IncidentPriority { get; set; }

        public IncidentStatus? IncidentStatus { get; set; }

        public bool SoftDelete { get; set; }

        public PropertyDto? Property { get; set; } = null;

        public CheckpointDto? Checkpoint { get; set; } = null;

        public IncidentTypeDto? IncidentType { get; set; } = null;

        public UserDto? CreatedByUser { get; set; } = null;

        public ICollection<IncidentAssignmentDto>? IncidentAssignments { get; set; } = null;

        public ICollection<IncidentActionDto>? Actions { get; set; } = null;
    }
}
