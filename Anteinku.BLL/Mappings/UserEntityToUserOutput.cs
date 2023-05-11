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
            UserName = userEntity.UserName,
            BirthDate = userEntity.BirthDate,
            PositionTitle = userEntity.Position.PositionTitle
        };

        return userOutput;
    }
}
