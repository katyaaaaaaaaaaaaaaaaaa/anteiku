using Anteiku.BLL.Helpers;
using Anteiku.BLL.Models;
using Anteiku.DAL.Entities;

namespace Anteiku.BLL.Mappings;

public static class UserEntityToUserOutput
{
    public static UserOutput? ToUserOutput(this UserEntity userEntity)
    {
        if (userEntity == null)
            return null;

        UserOutput userOutput = new()
        {
            Id = userEntity.UserId,
            UserName = userEntity.UserName,
            BirthDate = userEntity.BirthDate,
            ScheduleTime = ScheduleHelper.GetTimeAsStringFromEnum(userEntity.ScheduleTime),
            ScheduleDays = ScheduleHelper.GetDayAsStringFromEnum(userEntity.ScheduleDays),
            PositionTitle = userEntity.Position.PositionTitle,            
        };

        if (string.IsNullOrWhiteSpace(userEntity.Comment))
        {
            userOutput.Comment = "No comment";
        }
        else
        {
            userOutput.Comment = userEntity.Comment;
        }

        return userOutput;
    }
}
