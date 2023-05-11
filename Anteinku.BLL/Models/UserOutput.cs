namespace Anteiku.BLL.Models;

public class UserOutput
{
    public string UserName { get; set; } = string.Empty;

    public DateTime BirthDate { get; set; } = new DateTime();

    public string PositionTitle { get; set; } = string.Empty;
}
