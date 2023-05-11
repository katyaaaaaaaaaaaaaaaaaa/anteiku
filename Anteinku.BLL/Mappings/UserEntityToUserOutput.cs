using Anteiku.BLL.Models;
using Anteiku.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteiku.BLL.Mappings
{
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
                PositionId = userEntity.PositionId,
                Position = userEntity.Position
            };

            return userOutput;
        }
    }
}
