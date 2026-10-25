namespace ParaTrackDto.Models
{
    public class KeyActionDto
    {
        public Guid KeyActionId { get; set; }

        public Guid? KeyItemId { get; set; }

        public Guid? CheckedOutByUserId { get; set; }


        public DateTimeOffset? CheckedOutAt { get; set; }

        public Guid? CheckedInByUserId { get; set; }

        public DateTimeOffset? CheckedInAt { get; set; }

        public string? MediaUrl { get; set; }

        public string? MediaType { get; set; }

        public bool? SoftDelete { get; set; }

        public KeyItemDto? KeyItem { get; set; } = null;

        public UserDto? CheckedOutByUser { get; set; } = null;

        public UserDto? CheckedInByUser { get; set; } = null;
    }
}
