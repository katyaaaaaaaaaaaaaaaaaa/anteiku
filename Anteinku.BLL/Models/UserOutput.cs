using Anteiku.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteiku.BLL.Models
{
    public class UserOutput
    {
        public string UserName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = new DateTime();
        public int PositionId { get; set; } = 0;

        public PositionEntity Position { get; set; } = new PositionEntity();
    }
}
