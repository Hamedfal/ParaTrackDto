namespace ParaTrackDto.Models
{
    public class CheckpointDto
    {
        public Guid CheckpointId { get; set; }

        public Guid PropertyId { get; set; }

        public string? Instructions { get; set; }

        public string? QrCode { get; set; }

        public string? NfcTag { get; set; }

        public bool? PictureRequired { get; set; }

        public string? GreenComments { get; set; }

        public string? MediaUrl1 { get; set; }

        public string? MediaType1 { get; set; }

        public string? MediaUrl2 { get; set; }

        public string? MediaType2 { get; set; }

        public string? MediaUrl3 { get; set; }

        public string? MediaType3 { get; set; }

        public PropertyDto? Property { get; set; } = null;
    }
}
