using Anteiku.BLL.Helpers;
using Anteiku.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteiku.WinForms.Models
{
    internal class IngTypesViewModel
    {
        public IngTypesViewModel(IngridientType ingridientType)
        {
            TypeAsString = ScheduleHelper.GetTypeAsStringFromEnum(ingridientType);

            TypeAsEnum = ingridientType;
        }

        public string TypeAsString { get; }

        public IngridientType TypeAsEnum { get; }
    }
}
