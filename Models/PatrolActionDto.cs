namespace ParaTrackDto.Models
{
    public class PatrolActionDto
    {
        public Guid PatrolActionId { get; set; }

        public Guid? PatrolId { get; set; }

        public Guid? UserId { get; set; }

        public Guid? CheckpointId { get; set; }

        public DateTimeOffset? ActionTime { get; set; }

        public string? MediaUrl { get; set; }

        public string? MediaType { get; set; }

        public bool? HasIncident { get; set; }

        public string? GreenComment { get; set; }

        public bool SoftDelete { get; set; }

        public PatrolDto? Patrol { get; set; } = null;

        public CheckpointDto? Checkpoint { get; set; } = null;

        public UserDto? User { get; set; } = null;
    }
}
