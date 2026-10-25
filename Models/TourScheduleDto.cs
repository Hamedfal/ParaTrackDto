using ParaTrackDto.Types;

namespace ParaTrackDto.Models
{
    public class TourScheduleDto
    {
        public Guid ScheduleId { get; set; }

        public Guid? TourId { get; set; }

        public FrequencyType? Frequency { get; set; }

        public List<DayOfWeek>? TargetDays { get; set; }

        public bool? IncludeHolidays { get; set; }

        public bool? WeekdaysOnly { get; set; }

        public bool? WeekendsOnly { get; set; }

        public int? HourInterval { get; set; }

        public List<TimeOnly>? SpecificTimes { get; set; }

        public TimeOnly? WindowStart { get; set; }

        public TimeOnly? WindowEnd { get; set; }

        public TourDto? Tour { get; set; } = null;
    }
}
