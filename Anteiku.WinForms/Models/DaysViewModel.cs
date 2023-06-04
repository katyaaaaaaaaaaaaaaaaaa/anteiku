using Anteiku.BLL.Helpers;
using Anteiku.DAL.Enums;

namespace Anteiku.WinForms.Models;

public class DaysViewModel
{
    public DaysViewModel(ScheduleDays scheduleDay)
    {
        DayAsString = ScheduleHelper.GetDayAsStringFromEnum(scheduleDay);

        DayAsEnum = scheduleDay;
    }

    public string DayAsString { get; }

    public ScheduleDays DayAsEnum { get; }   
}

