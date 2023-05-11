using Anteiku.BLL.Models;
using Anteiku.DAL.Entities;

namespace Anteiku.BLL.Mappings;

public static class PositionEntityToPositionOutput
{
    public static PositionOutput? ToPositionOutput(this PositionEntity positionEntity)
    {
        if (positionEntity == null)
            return null;

        PositionOutput positionOutput = new()
        {
            PositionId = positionEntity.PositionId,
            PositionTitle = positionEntity.PositionTitle
        };

        return positionOutput;
    }
}
