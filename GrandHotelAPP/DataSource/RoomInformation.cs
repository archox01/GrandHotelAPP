using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandHotelAPP.DataSource
{
   public class RoomInformation
    {
        public int RoomId { get; set; }
        public int RoomTypeId { get; set; }
        public string RoomNumber{ get; set; }
        public string RoomFloor { get; set; }
        public string Description { get; set; }

    }
}
