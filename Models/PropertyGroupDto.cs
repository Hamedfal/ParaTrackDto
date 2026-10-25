namespace ParaTrackDto.Models
{
    public class PropertyGroupDto
    {
        public Guid RowId { get; set; }

        public Guid GroupId { get; set; }

        public Guid PropertyId { get; set; }

        public ManagementGroupDto? ManagementGroup { get; set; }

        public PropertyDto? Property { get; set; }
    }
}
