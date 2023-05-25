using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHoRoBo.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public int RoomTypeId { get; set; }
        public RoomTypes RoomTypes { get; set; }

        public RoomAvail RoomAvail { get; set; }
        public decimal Price { get; set; }
        public string RoomPicture { get; set; }
        public ICollection<RoomFacilities> RoomFacilities { get; set; }=new HashSet<RoomFacilities>();

    }  
    public enum RoomAvail:int
    {
        Booked=0,
        Available=1
    }
}
