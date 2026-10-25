namespace ParaTrackDto.Models
{
    public class IncidentAssignmentDto
    {
        public Guid RowId { get; set; }

        public Guid? IncidentId { get; set; }

        public Guid? ByUserId { get; set; }

        public Guid? ToUserId { get; set; }

        public DateTimeOffset? AssignedAt { get; set; }

        public IncidentDto? Incident { get; set; } = null;

        public UserDto? ByUser { get; set; } = null;

        public UserDto? ToUser { get; set; } = null;
    }
}
