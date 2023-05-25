using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHoRoBo.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        [Required]
        public int OrderHeaderId { get; set; }
        public OrderHeader OrderHeader { get; set; }

        [Required]
        public int RoomId { get; set; }
        public Room Room { get; set; }

        public decimal Price { get; set; }
        public int TotalDays { get; set; }
    }
}
