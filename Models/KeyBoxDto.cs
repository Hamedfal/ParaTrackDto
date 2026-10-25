namespace ParaTrackDto.Models
{
    public class KeyBoxDto
    {
        public Guid KeyBoxId { get; set; }

        public Guid? PropertyId { get; set; }

        public string? KeyBoxName { get; set; }

        public string? LocationNotes { get; set; }

        public string? MediaUrl { get; set; }

        public string? MediaType { get; set; }

        public bool? SoftDelete { get; set; }

        public PropertyDto? Property { get; set; } = null;

        public ICollection<KeyRingDto>? KeyRings { get; set; } = null;

        public ICollection<KeyItemDto>? KeyItems { get; set; } = null;
    }
}
