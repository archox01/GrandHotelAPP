using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandHotelAPP.DataSource
{
    public class ReservationInformation
    {
        public int ReservationId { get; set; }
        public DateTime DateTime { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public string Code { get; set; }
    }
}
