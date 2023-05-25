using OnHoRoBo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHoRoBo.Services
{
    public interface IRoomTypeService
    {
        //PagedResult<RoomTypeViewModel> GetAllRoomType(int pageNumber, int pageSize);
        IEnumerable<RoomTypeViewModel> AllRoomType();
        RoomTypeViewModel GetRoomType(int TypeId);
        void UpdateRoomType(RoomTypeViewModel roomType);
        void InsertRoomType(RoomTypeViewModel roomType);
        void DeleteRoomType(int id);
    }
}
