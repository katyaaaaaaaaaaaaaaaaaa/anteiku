using Anteiku.BLL.Models;
using Anteiku.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteiku.BLL.Mappings
{
    internal static class IngridientEntityToIngridientOutput
    {
        public static IngridientOutput? ToIngridientOutput(this IngridientEntity ingridientEntity)
        {
            if (ingridientEntity == null)
                return null;

            IngridientOutput ingridientOutput = new()
            {
                Title = ingridientEntity.IngridientTitle
            };

            return ingridientOutput;
        }
    }
}
