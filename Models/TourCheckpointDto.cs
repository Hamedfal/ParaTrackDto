namespace ParaTrackDto.Models
{
    public class TourCheckpointDto
    {
        public Guid RowId { get; set; }

        public Guid? TourId { get; set; }

        public Guid? CheckpointId { get; set; }

        public int? PatrolOrder { get; set; }

        public TourDto? Tour { get; set; } = null;

        public CheckpointDto? Checkpoint { get; set; } = null;
    }
}
