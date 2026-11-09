namespace POE_RaceDay_API1.DTOs
{
    public class EventRequest
    {
        public string EventName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; } = string.Empty;
    }
}
