namespace Anteiku.BLL.Models;

public class UserOutput
{
    public int Id { get; set; }

    public string UserName { get; set; } = string.Empty;

    public DateTime BirthDate { get; set; } = new DateTime();

    public string ScheduleDays { get; set; } = string.Empty;

    public string ScheduleTime { get; set; } = string.Empty;

    public string PositionTitle { get; set; } = string.Empty;

    public string Comment { get; set; } = string.Empty;
}
