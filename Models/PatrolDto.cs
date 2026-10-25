using ParaTrackDto.Types;

namespace ParaTrackDto.Models
{
    public class PatrolDto
    {
        public Guid PatrolId { get; set; }

        public Guid? PropertyId { get; set; }

        public Guid? TourId { get; set; }

        public Guid? ScheduleId { get; set; }

        public PatrolStatus? PatrolStatus { get; set; }

        public Guid? UserId { get; set; }

        public DateTimeOffset? StartTime { get; set; }

        public DateTimeOffset? EndTime { get; set; }

        public PropertyDto? Property { get; set; } = null;

        public TourDto? Tour { get; set; } = null;

        public TourScheduleDto? TourSchedule { get; set; } = null;

        public UserDto? User { get; set; } = null;

        public ICollection<PatrolActionDto>? PatrolActions { get; set; } = null;
    }
}
