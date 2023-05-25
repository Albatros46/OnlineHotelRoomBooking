using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHoRoBo.Models
{
    public class OrderHeader
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }

        public ApplicationUser Customer { get; set; }

        [Required]
        public DateTime DateOfOrder { get; set; }

        public decimal OrderTotal { get; set; }
        public string? OrderStatus { get; set; }
        public string? PaymentStatus { get; set; }

        public string? SessionId { get; set; }
        public string? PaymentIntentId { get; set; }
        public DateTime DateOfPayment { get; set; }
        public DateTime DueDate { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string Name { get; set; }


    }
}
