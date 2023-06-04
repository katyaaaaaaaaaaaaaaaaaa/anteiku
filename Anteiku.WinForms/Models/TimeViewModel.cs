using Anteiku.BLL.Helpers;
using Anteiku.DAL.Enums;

namespace Anteiku.WinForms.Models;

public class TimeViewModel
{
    public TimeViewModel(ScheduleTime schedule)
    {
        TimeAsString = ScheduleHelper.GetTimeAsStringFromEnum(schedule);

        TimeAsEnum = schedule;
    }

    public string TimeAsString { get; }

    public ScheduleTime TimeAsEnum { get; }
}
