using System.ComponentModel.DataAnnotations;

namespace GiftAccessoriesManagement.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required, MaxLength(30)]
        public string? EventCode { get; set; }

        [Required, MaxLength(255)]
        public string? EventName { get; set; }

        public string? Description { get; set; }

        [Required]
        public float Discount { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int Status { get; set; }
        // Navigation property
        //public virtual ICollection<EventProduct> EventProducts { get; set; } = new List<EventProduct>();
    }
}
