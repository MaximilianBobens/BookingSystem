namespace BlazorApp2.Pages;

public class BookingModel
{
    public string TraineeName { get; set; } = string.Empty;
    public string Station { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public string Status { get; set; } = string.Empty;
}