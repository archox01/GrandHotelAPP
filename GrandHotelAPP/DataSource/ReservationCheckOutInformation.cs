using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandHotelAPP.DataSource
{
    public class ReservationCheckOutInformation
    {
        public int ReservervationCheckOutId { get; set; }
        public int ReservationRoomId { get; set; }
        public int ItemId { get; set; }
        public int ItemStatusId { get; set; }
        public int Qty { get; set; }
        public int TotalCharge { get; set; }

    }
}
