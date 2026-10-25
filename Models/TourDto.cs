namespace ParaTrackDto.Models
{
    public class TourDto
    {
        public Guid TourId { get; set; }

        public Guid? PropertyId { get; set; }

        public string? TourName { get; set; }

        public string? Description { get; set; }

        public bool? IsActive { get; set; }

        public ICollection<TourScheduleDto>? TourSchedules { get; set; } = null;

        public PropertyDto? Property { get; set; } = null;

        public ICollection<TourCheckpointDto>? TourCheckpoints { get; set; } = null;
    }
}
