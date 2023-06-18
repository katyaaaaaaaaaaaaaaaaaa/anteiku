using Anteiku.DAL.Enums;

namespace Anteiku.BLL.Helpers;

public static class ScheduleHelper
{
    public static string GetDayAsStringFromEnum(ScheduleDays schedule)
    {
        return schedule switch
        {
            ScheduleDays.FIVEDAY => "Пятидневка",
            ScheduleDays.SEVENDAY => "Семидневка",
            ScheduleDays.DUTY => "Дежурство",
            _ => throw new ArgumentException(),
        };
    }

    public static ScheduleDays GetDayAsEnumFromString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentNullException();
        }

        return input switch
        {
            "Пятидневка" => ScheduleDays.FIVEDAY,
            "Семидневка" => ScheduleDays.SEVENDAY,
            "Дежурство" => ScheduleDays.DUTY,
            _ => throw new ArgumentException(),
        };
    }

    public static string GetTimeAsStringFromEnum(ScheduleTime schedule)
    {
        return schedule switch
        {
            ScheduleTime.START_8_00_END_17_00 => "8:00-17:00",
            ScheduleTime.START_17_00_END_01_00 => "17:00-1:00",
            ScheduleTime.START_08_00_END_08_00 => "8:00-8:00",
            ScheduleTime.START_07_00_END_14_00 => "7:00-14:00",
            _ => throw new ArgumentException(),
        };
    }

    public static ScheduleTime GetTimeAsEnumFromString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentNullException();
        }

        return input switch
        {
            "8:00-17:00" => ScheduleTime.START_8_00_END_17_00,
            "17:00-1:00" => ScheduleTime.START_17_00_END_01_00,
            "8:00-8:00" => ScheduleTime.START_08_00_END_08_00,
            "7:00-14:00" => ScheduleTime.START_07_00_END_14_00,
            _ => throw new ArgumentException(),
        };
    }

    public static string GetTypeAsStringFromEnum(IngridientType ingridientType)
    {
        return ingridientType switch
        {
            IngridientType.COUNT => "Количество",
            IngridientType.GRAMS => "Граммы",
            IngridientType.MILLILITERS => "Миллилитры",
            _ => throw new ArgumentException(),
        };
    }
    public static IngridientType GetTypeAsEnumFromString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentNullException();
        }

        return input switch
        {
            "Количество" => IngridientType.COUNT,
            "Граммы" => IngridientType.GRAMS,
            "Миллилитры" => IngridientType.MILLILITERS,
            _ => throw new ArgumentException(),
        };
    }


}
