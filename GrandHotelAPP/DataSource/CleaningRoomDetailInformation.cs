using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandHotelAPP.DataSource
{
    public class CleaningRoomDetailInformation
    {
        public int CleaningRoomDetailId { get; set; }
        public int CleaningRoomId { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDateTime{ get; set; }
        public DateTime FinishDateTime { get; set; }
        public string Note { get; set; }
        public string StatusCleaning { get; set; }


    }
}
