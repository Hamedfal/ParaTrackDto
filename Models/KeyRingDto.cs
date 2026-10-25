namespace ParaTrackDto.Models
{
    public class KeyRingDto
    {
        public Guid KeyRingId { get; set; }

        public Guid? PropertyId { get; set; }

        public Guid? KeyBoxId { get; set; }

        public string? KeyRingName { get; set; }

        public string? LocationNotes { get; set; }

        public string? MediaUrl { get; set; }

        public string? MediaType { get; set; }

        public bool? SoftDelete { get; set; }

        public PropertyDto? Property { get; set; } = null;

        public KeyBoxDto? KeyBox { get; set; } = null;

        public ICollection<KeyItemDto>? KeyItems { get; set; } = null;
    }
}
