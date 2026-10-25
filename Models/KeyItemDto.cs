using ParaTrackDto.Types;

namespace ParaTrackDto.Models
{
    public class KeyItemDto
    {
        public Guid KeyItemId { get; set; }

        public Guid? PropertyId { get; set; }

        public Guid? KeyRingId { get; set; }

        public Guid? KeyBoxId { get; set; }

        public KeyType? KeyType { get; set; }

        public string? LocationNotes { get; set; }

        public string? MediaUrl { get; set; }

        public string? MediaType { get; set; }

        public string? LockMediaUrl { get; set; }

        public string? LockMediaType { get; set; }

        public bool? SoftDelete { get; set; }

        public PropertyDto? Property { get; set; } = null;

        public KeyRingDto? KeyRing { get; set; } = null;

        public KeyBoxDto? KeyBox { get; set; } = null;
    }
}
