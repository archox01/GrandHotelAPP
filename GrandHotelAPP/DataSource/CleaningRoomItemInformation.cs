using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandHotelAPP.DataSource
{
    public class CleaningRoomItemInformation
    {
        public int CleaningRoomItemId { get; set; }
        public int CleaningRoomDetailId { get; set; }
        public int ItemId { get; set; }
        public int Qty { get; set; }
        public string Status { get; set; }
    }
}
