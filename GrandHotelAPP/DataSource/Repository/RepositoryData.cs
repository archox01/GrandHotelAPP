using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandHotelAPP.DataSource.Repository
{
    public class RepositoryData
    {
        public List<CleaningRoomDetailInformation> CRDetailRepository()
        {
            using (GrandHotelContext Context = new GrandHotelContext())
            {
                return Context.CleaningRoomDetails.Select(a => new CleaningRoomDetailInformation()
                {
                    CleaningRoomDetailId = a.CleaningRoomDetailId,
                    CleaningRoomId = a.CleaningRoomId,
                    RoomId = a.RoomId,
                    StartDateTime = a.StartDateTime,
                    FinishDateTime = a.FinishDateTime,
                    Note = a.Note,
                    StatusCleaning = a.StatusCleaning
                }).ToList();
            }
        }
        public List<CleaningRoomInformation> CRRepository()
        {
            using (GrandHotelContext Context = new GrandHotelContext())
            {
                return Context.CleaningRooms.Select(a => new CleaningRoomInformation()
                {
                    CleaningRoomId = a.CleaningRoomId,
                    EmployeeId = a.EmployeeId,
                    Date = a.Date
                }).ToList();
            }
        }
        public List<CleaningRoomItemInformation> CRIRepository()
        {
            using (GrandHotelContext Context = new GrandHotelContext())
            {
                return Context.CleaningRoomItems.Select(a => new CleaningRoomItemInformation()
                {
                    CleaningRoomDetailId = a.CleaningRoomDetailId,
                    CleaningRoomItemId = a.CleaningRoomItemId,
                    ItemId = a.ItemId,
                    Qty = a.Qty,
                    Status = a.Status
                }).ToList();
            }
        }
    }
}
