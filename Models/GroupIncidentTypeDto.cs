namespace ParaTrackDto.Models
{
    public class GroupIncidentTypeDto
    {
        public Guid RowId { get; set; }

        public Guid GroupId { get; set; }

        public Guid IncidentTypeId { get; set; }

        public ManagementCompanyDto? ManagementGroup { get; set; } = null;

        public IncidentTypeDto? IncidentType { get; set; } = null;
    }
}
